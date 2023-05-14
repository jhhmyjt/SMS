using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;

namespace SkillSystem.Server.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _dataContext;
        private readonly IConfiguration _configuration;//注入app setting使用设置中的密钥

        public AuthService(DataContext dataContext,IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<string>> Login(string email, string password)
        {
            var response = new ServiceResponse<string>();
            //检查用户是否存在
            var user= await _dataContext.Users.FirstOrDefaultAsync(
                u=>u.Email.ToLower().Equals(email.ToLower()));
            if (user == null) { 
                response.Success = false;
                response.Message = "未找到用户";
            }
            else
            {
                //存在用户，匹配密码
                if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                {
                    response.Success = false;
                    response.Message = "密码不正确";
                }
                else
                {
                    response.Data = CreateToken(user);
                }
            }
            return response;
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            //检查邮箱是否注册过
            if(await UserExist(user.Email))
            {
                return new ServiceResponse<int> { Success = false,Message="用户邮箱已经存在" };
            }
            //创建密码哈希
            CreatePasswordHash(password,out byte[] passwordHash,out byte[] passwordSalt);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            //添加该用户
            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<int> { Data = user.Id, Message="注册成功！"};
        }

        public async Task<bool> UserExist(string email)
        {
            if(await _dataContext.Users.AnyAsync(u=>u.Email.ToLower().Equals(email.ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {
            //使用密码加密算法
            using (var hmac=new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac=new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
        private string CreateToken(User user)
        {
            //令牌可以存储一些声明，如邮箱、id等
            List<Claim> claims = new List<Claim> { 
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.Email),
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));
            //使用生成的key创建一个新的签名凭证
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            //获取令牌，有效期位1天
            var token = new JwtSecurityToken(
                claims:claims,
                expires:DateTime.Now.AddDays(1),
                signingCredentials:creds
                );
            var jwt=new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public async Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword)
        {
            var user=await _dataContext.Users.FindAsync(userId);
            if(user == null)
            {
                return new ServiceResponse<bool> { Success = false, Message="未找到用户"};
            }
            //存在用户，修改密码。重新创建Hash
            CreatePasswordHash(newPassword, out byte[] newPasswordHash, out byte[] newPasswordSalt);
            user.PasswordSalt = newPasswordSalt;
            user.PasswordHash = newPasswordHash;

            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true ,Message="用户密码已修改"};
        }
    }
}

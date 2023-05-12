using System.Security.Cryptography;

namespace SkillSystem.Server.Data
{
	public class DataContext:DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //预先生成密码
            CreatePasswordHash("123456", out byte[] passwordHash1, out byte[] passwordSalt1);
            CreatePasswordHash("abcdef", out byte[] passwordHash2, out byte[] passwordSalt2);
            CreatePasswordHash("asdfda", out byte[] passwordHash3, out byte[] passwordSalt3);
            CreatePasswordHash("sadfasdfa123", out byte[] passwordHash4, out byte[] passwordSalt4);
            CreatePasswordHash("admin123", out byte[] passwordHash5, out byte[] passwordSalt5);
            modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = 1,
					Email="duyou@super.com",
					isSuper=true,
					DateCreated= DateTime.Now,
                    PasswordHash=passwordHash1,
                    PasswordSalt=passwordSalt1,
				},
                new User
                {
                    Id = 2,
                    Email = "duyou2@super.com",
                    isSuper = true,
                    DateCreated = DateTime.Now,
                    PasswordHash=passwordHash2,
                    PasswordSalt=passwordSalt2,
                },
                new User
                {
                    Id = 3,
                    Email = "duyou3@super.com",
                    isSuper = true,
                    DateCreated = DateTime.Now,
                    PasswordHash=passwordHash3,
                    PasswordSalt=passwordSalt3,
                },
                new User
                {
                    Id = 4,
                    Email = "duyou4@super.com",
                    isSuper = true,
                    DateCreated = DateTime.Now,
                    PasswordHash=passwordHash4,
                    PasswordSalt=passwordSalt4,
                },
                new User
                {
                    Id = 5,
                    Email = "duyou5@super.com",
                    isSuper = true,
                    DateCreated = DateTime.Now,
                    PasswordHash=passwordHash5,
                    PasswordSalt=passwordSalt5,
                }
                );
        }
        public DbSet<User> Users { get; set; }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //使用密码加密算法
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}

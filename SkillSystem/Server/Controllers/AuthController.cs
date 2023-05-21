using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace SkillSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var response = await _authService.Register(
                new User { Email=request.Email },request.Password
                );
            if(!response.Success) { return BadRequest(response); } return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request)
        {
            var response = await _authService.Login(request.Email, request.Password);
            if (!response.Success) { return BadRequest(response); }
            return Ok(response);
        }

        //使用Authorize限定只有授权用户可以调用此方法
        [HttpPost("change-password"),Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string newPassword)
        {
            //从JWT Token的payload中的主体信息获取用户id，代码：new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response=await _authService.ChangePassword(int.Parse(userId), newPassword);
            if(!response.Success) { return BadRequest(response); }
            return Ok(response);
        }
        [HttpPost("change-info"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangeInfo([FromBody] UserInfo userInfo)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _authService.ChangeInfo(int.Parse(userId), userInfo.Name, userInfo.Phone);
            if (!response.Success) { return BadRequest(response); }
            return Ok(response);
        }
    }
}

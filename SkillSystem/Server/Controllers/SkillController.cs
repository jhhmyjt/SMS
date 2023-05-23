using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SkillSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<SkillLicense>>>> GetSkillLicenses()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _skillService.GetSkillLicense(int.Parse(userId));
            return result;
        }
    }
}

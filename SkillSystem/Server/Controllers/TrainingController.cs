using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SkillSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingService _trainingService;

        public TrainingController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Training>>>> GetTrainings()
        {
            var result = await _trainingService.GetTrainings();
            return result;
        }
        [HttpGet("{trainingId}")]
        public async Task<ActionResult<ServiceResponse<Training>>> GetTraining(int trainingId)
        {
            var result = await _trainingService.GetTraining(trainingId);
            return Ok(result);
        }
        [HttpPost("register-training"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangeInfo([FromBody] int trainingId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _trainingService.RegisterTraining(int.Parse(userId), trainingId);
            if (!response.Success) { return BadRequest(response); }
            return Ok(response);
        }
        [HttpGet("get-training-items"), Authorize]
        public async Task<ActionResult<ServiceResponse<List<TrainingItem>>>> GetTrainingItems()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _trainingService.GetTrainingItems(int.Parse(userId));
            return result;
        }
        [HttpGet("admin/{trainingId}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Training>>> GetAdminTraining(int trainingId)
        {
            var result = await _trainingService.GetAdminTraining(trainingId);
            return Ok(result);
        }
        [HttpGet("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<Training>>>> GetAdminTrainings()
        {
            var result = await _trainingService.GetAdminTrainings();
            return result;
        }
        [HttpDelete("admin/{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteTraining(int id)
        {
            var result = await _trainingService.DeleteTraining(id);
            return result;
        }
        [HttpPost("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Training>>> CreateTraining(Training training)
        {
            var result = await _trainingService.CreateTraining(training);
            return result;
        }
        [HttpPut("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Training>>> UpdateTraining(Training training)
        {
            var result = await _trainingService.UpdateTraining(training);
            return result;
        }
    }
}

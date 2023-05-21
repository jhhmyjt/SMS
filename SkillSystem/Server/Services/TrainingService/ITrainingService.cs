namespace SkillSystem.Server.Services.TrainingService
{
    public interface ITrainingService
    {
        Task<ServiceResponse<List<Training>>> GetTrainings();
    }
}

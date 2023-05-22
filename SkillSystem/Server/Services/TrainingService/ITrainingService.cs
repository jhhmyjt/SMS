namespace SkillSystem.Server.Services.TrainingService
{
    public interface ITrainingService
    {
        Task<ServiceResponse<List<Training>>> GetTrainings();
        Task<ServiceResponse<Training>> GetTraining(int trainingId);
        Task<ServiceResponse<bool>> RegisterTraining(int userId, int trainingId);
        Task<ServiceResponse<List<TrainingItem>>> GetTrainingItems(int userId);
    }
}

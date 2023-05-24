namespace SkillSystem.Server.Services.TrainingService
{
    public interface ITrainingService
    {
        Task<ServiceResponse<List<Training>>> GetTrainings();
        Task<ServiceResponse<Training>> GetTraining(int trainingId);
        Task<ServiceResponse<bool>> RegisterTraining(int userId, int trainingId);
        Task<ServiceResponse<List<TrainingItem>>> GetTrainingItems(int userId);
        Task<ServiceResponse<Training>> GetAdminTraining(int trainingId);
        Task<ServiceResponse<List<Training>>> GetAdminTrainings();  //获取所有的培训，包括已完成的、结束报名的等
        Task<ServiceResponse<Training>> CreateTraining(Training training);
        Task<ServiceResponse<Training>> UpdateTraining(Training training);
        Task<ServiceResponse<bool>> DeleteTraining(int id);
    }
}

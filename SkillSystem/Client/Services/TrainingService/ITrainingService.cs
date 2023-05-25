namespace SkillSystem.Client.Services.TrainingService
{
    public interface ITrainingService
    {
        event Action OnChange;  //服务事件，当Training发生改变时，通知订阅事件的组件
        List<Training> AdminTrainings { get; set; }
        List<Training> Trainings { get; set; }
        List<TrainingItem> TrainingItems { get; set; }
        Task GetTrainings();
        Task<ServiceResponse<Training>> GetTraining(int trainingId);
        Task<ServiceResponse<Training>> GetAdminTraining(int trainingId);
        Task<ServiceResponse<bool>> RegisterTraining(int trainingId);
        Task GetTrainingItems();
        Task GetAdminTraining();
        Task<Training> CreateTraining(Training training);
        Task<Training> UpdateTraining(Training training);
        Task DeleteTraining(Training training);
    }
}

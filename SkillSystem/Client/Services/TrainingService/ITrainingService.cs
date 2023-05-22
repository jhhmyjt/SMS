namespace SkillSystem.Client.Services.TrainingService
{
    public interface ITrainingService
    {
        List<Training> Trainings { get; set; }
        Task GetTrainings();
        Task<ServiceResponse<Training>> GetTraining(int trainingId);
        Task<ServiceResponse<bool>> RegisterTraining(int trainingId);
    }
}

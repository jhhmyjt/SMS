namespace SkillSystem.Client.Services.TrainingService
{
    public interface ITrainingService
    {
        List<Training> Trainings { get; set; }
        Task GetTrainings();
    }
}

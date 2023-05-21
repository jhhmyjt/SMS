namespace SkillSystem.Server.Services.TrainingService
{
    public class TrainingService : ITrainingService
    {
        private readonly DataContext _context;
        public TrainingService(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<ServiceResponse<List<Training>>> GetTrainings()
        {
            var response = new ServiceResponse<List<Training>>
            {
                Data = await _context.Training.ToListAsync()
            };
            return response;
        }
    }
}

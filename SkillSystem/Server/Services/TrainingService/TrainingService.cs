namespace SkillSystem.Server.Services.TrainingService
{
    public class TrainingService : ITrainingService
    {
        private readonly DataContext _context;

        public TrainingService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ServiceResponse<Training>> GetTraining(int trainingId)
        {
            var response=new ServiceResponse<Training>();
            var training=await _context.Training
                .Include(t=>t.Course)
                .ThenInclude(c=>c.Skill)
                .ThenInclude(s=>s.Variants)
                .ThenInclude(v=>v.SkillType)
                .FirstOrDefaultAsync(t=>t.Id==trainingId);
            if (training == null)
            {
                response.Success = false;
                response.Message = "未找到";
            }
            else
            {
                response.Data = training;
            }
            return response;
        }

        public async Task<ServiceResponse<List<TrainingItem>>> GetTrainingItems(int userId)
        {
            var response=new ServiceResponse<List<TrainingItem>>();
            var items = await _context.TrainingItems.
                Include(t=>t.Training).
                Where(t => t.UserId == userId).
                OrderByDescending(t => t.RegisterTime).
                ToListAsync();
            response.Data = items;
            return response;
        }

        public async Task<ServiceResponse<List<Training>>> GetTrainings()
        {
            var response = new ServiceResponse<List<Training>>
            {
                Data = await _context.Training.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<bool>> RegisterTraining(int userId,int trainingId)
        {
            var training = await _context.Training.FindAsync(trainingId);
            if (training == null)
            {
                return new ServiceResponse<bool> { Success = false,Message="未找到培训"};
            }
            //判断报名人数
            if (training.RegisterNumber >= training.MaxCapacity)
            {
                return new ServiceResponse<bool> { Success = false, Message = "报名人数已满" };
            }
            //判断是否已经报名
            var existItem = await _context.TrainingItems.FirstOrDefaultAsync(t => t.TrainingId == trainingId && t.UserId == userId);
            if (existItem != null) {
                return new ServiceResponse<bool> { Success = false, Message = "您已报名，请不要重复报名" };
            }
            //用户报名培训，生成培训项目
            var trainingItem = new TrainingItem();
            trainingItem.UserId = userId;
            trainingItem.TrainingId = trainingId;
            //报名人数加一
            training.RegisterNumber += 1;
            //向数据库中添加培训项目
            _context.TrainingItems.Add(trainingItem);
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
        }
    }
}

namespace SkillSystem.Server.Services.TrainingService
{
    public class TrainingService : ITrainingService
    {
        private readonly DataContext _context;

        public TrainingService(DataContext dataContext)
        {
            _context = dataContext;
        }

        private async Task<Training> GetTrainingById(int id)
        {
            return await _context.Training
                .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<ServiceResponse<List<Training>>> GetAdminTrainings()
        {
            var response = new ServiceResponse<List<Training>>
            {
                Data = await _context.Training
                .Where(t => !t.Deleted)
                .ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<Training>> GetTraining(int trainingId)
        {
            var response = new ServiceResponse<Training>();
            var training = await _context.Training
                .Include(t => t.Course)
                .ThenInclude(c => c.Skill)
                .ThenInclude(s => s.Variants)
                .ThenInclude(v => v.SkillType)
                .FirstOrDefaultAsync(t => t.Id == trainingId && !t.Deleted && t.Visible);
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
            var response = new ServiceResponse<List<TrainingItem>>();
            var items = await _context.TrainingItems.
                Include(t => t.Training).
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
                Data = await _context.Training
                .Where(t => !t.Deleted && !t.Finished && t.Visible && t.Registering)
                .ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<bool>> RegisterTraining(int userId, int trainingId)
        {
            var training = await _context.Training.FindAsync(trainingId);
            if (training == null)
            {
                return new ServiceResponse<bool> { Success = false, Message = "未找到培训" };
            }
            //判断报名人数
            if (training.RegisterNumber >= training.MaxCapacity)
            {
                return new ServiceResponse<bool> { Success = false, Message = "报名人数已满" };
            }
            //判断是否已经报名
            var existItem = await _context.TrainingItems.FirstOrDefaultAsync(t => t.TrainingId == trainingId && t.UserId == userId);
            if (existItem != null)
            {
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

        public async Task<ServiceResponse<Training>> GetAdminTraining(int trainingId)
        {
            var response = new ServiceResponse<Training>();
            var training = await _context.Training
                .Include(t => t.Course)
                .ThenInclude(c => c.Skill)
                .ThenInclude(s => s.Variants)
                .ThenInclude(v => v.SkillType)
                .FirstOrDefaultAsync(t => t.Id == trainingId && !t.Deleted);
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

        public async Task<ServiceResponse<Training>> CreateTraining(Training training)
        {
            _context.Training.Add(training);
            await _context.SaveChangesAsync();
            return new ServiceResponse<Training> { Data = training };
        }

        public async Task<ServiceResponse<Training>> UpdateTraining(Training training)
        {
            var dbTraining = await _context.Training.FindAsync(training.Id);
            if (dbTraining == null)
            {
                return new ServiceResponse<Training>
                {
                    Message = "未找到培训",
                    Success = false
                };
            }
            dbTraining.EndTime = training.EndTime;
            dbTraining.StartTime = training.StartTime;
            dbTraining.Name = training.Name;
            dbTraining.Description = training.Description;
            dbTraining.MaxCapacity = training.MaxCapacity;
            dbTraining.CourseId = training.CourseId;
            dbTraining.Type = training.Type;
            dbTraining.Status = training.Status;
            dbTraining.Visible = training.Visible;
            dbTraining.Going = training.Going;
            dbTraining.Registering = training.Registering;

            await _context.SaveChangesAsync();
            return new ServiceResponse<Training> { Data = training };
        }

        public async Task<ServiceResponse<bool>> DeleteTraining(int id)
        {
            var dbTraining = await _context.Training.FindAsync(id);
            if (dbTraining == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Message = "未找到培训",
                    Success = false
                };
            }

            dbTraining.Deleted = true;
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
        }
    }
}

using SkillSystem.Shared;

namespace SkillSystem.Server.Services.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly DataContext _context;
        public CourseService(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<ServiceResponse<List<Course>>> GetCourses()
        {
            var response = new ServiceResponse<List<Course>>();
            var courses = await _context.Courses
                .Include(c => c.Skill)
                .Include(c => c.SkillType)
                .ToListAsync();
            if (courses == null)
            {
                response.Success = false;
                response.Message = "没有任何课程";
            }
            else
            {
                response.Data = courses;
            }
            return response;
        }
    }
}

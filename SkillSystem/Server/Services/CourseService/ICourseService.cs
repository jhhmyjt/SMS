namespace SkillSystem.Server.Services.CourseService
{
    public interface ICourseService
    {
        Task<ServiceResponse<List<Course>>> GetCourses();
    }
}

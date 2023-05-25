namespace SkillSystem.Client.Services.CourseService
{
    public interface ICourseService
    {
        public List<Course> Courses { get; set; }
        Task GetCourses();
    }
}

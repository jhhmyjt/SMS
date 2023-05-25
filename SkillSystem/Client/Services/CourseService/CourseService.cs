using SkillSystem.Shared;
using System.Net.Http.Json;

namespace SkillSystem.Client.Services.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly HttpClient _httpClient;
        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Course> Courses { get; set; }=new List<Course>();

        public async Task GetCourses()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Course>>>("api/course");
            if (result != null && result.Data != null)
            {
                Courses = result.Data;
            }
        }
    }
}

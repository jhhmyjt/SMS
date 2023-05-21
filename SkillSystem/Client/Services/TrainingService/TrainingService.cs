using System.Net.Http.Json;

namespace SkillSystem.Client.Services.TrainingService
{
    public class TrainingService : ITrainingService
    {
        private readonly HttpClient _http;

        public TrainingService(HttpClient http)
        {
            _http = http;
        }
        public List<Training> Trainings { get; set; }=new List<Training>();

        public async Task GetTrainings()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Training>>>("api/training");
            if (result != null && result.Data != null) { Trainings=result.Data; }
        }
    }
}

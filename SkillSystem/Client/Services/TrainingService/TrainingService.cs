using System.Net.Http;
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
        public List<TrainingItem> TrainingItems { get; set; }=new List<TrainingItem>();

        public async Task<ServiceResponse<Training>> GetTraining(int trainingId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Training>>($"api/training/{trainingId}");
            return result;
        }

        public async Task GetTrainingItems()
        {
            var result= await _http.GetFromJsonAsync<ServiceResponse<List<TrainingItem>>>("api/training/get-training-items");
            if (result != null && result.Data != null) { TrainingItems = result.Data; }
        }

        public async Task GetTrainings()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Training>>>("api/training");
            if (result != null && result.Data != null) { Trainings=result.Data; }
        }

        public async Task<ServiceResponse<bool>> RegisterTraining(int trainingId)
        {
            var result = await _http.PostAsJsonAsync("api/training/register-training", trainingId);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}

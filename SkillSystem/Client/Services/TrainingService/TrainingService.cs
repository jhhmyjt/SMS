using System.Net.Http;
using System.Net.Http.Json;

namespace SkillSystem.Client.Services.TrainingService
{
    public class TrainingService : ITrainingService
    {
        private readonly HttpClient _httpClient;

        public TrainingService(HttpClient http)
        {
            _httpClient = http;
        }
        public List<Training> Trainings { get; set; }=new List<Training>();
        public List<TrainingItem> TrainingItems { get; set; }=new List<TrainingItem>();
        public List<Training> AdminTrainings { get; set; }=new List<Training>();

        public event Action OnChange;

        public async Task<Training> CreateTraining(Training training)
        {
            var result = await _httpClient.PostAsJsonAsync("api/training/admin", training);
            var newTraining =(await result.Content
                .ReadFromJsonAsync<ServiceResponse<Training>>()).Data;
            return newTraining;
        }

        public async Task DeleteTraining(Training training)
        {
            var result = await _httpClient.DeleteAsync($"api/training/admin/{training.Id}");
        }

        public async Task<Training> UpdateTraining(Training training)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/training/admin", training);
            return (await result.Content
                .ReadFromJsonAsync<ServiceResponse<Training>>()).Data;
        }

        public async Task GetAdminTraining()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Training>>>("api/training/admin");
            if (result != null && result.Data != null) { AdminTrainings = result.Data; }
        }

        public async Task<ServiceResponse<Training>> GetAdminTraining(int trainingId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Training>>($"api/training/admin/{trainingId}");
            return result;
        }

        public async Task<ServiceResponse<Training>> GetTraining(int trainingId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Training>>($"api/training/{trainingId}");
            return result;
        }

        public async Task GetTrainingItems()
        {
            var result= await _httpClient.GetFromJsonAsync<ServiceResponse<List<TrainingItem>>>("api/training/get-training-items");
            if (result != null && result.Data != null) { TrainingItems = result.Data; }
        }

        public async Task GetTrainings()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Training>>>("api/training");
            if (result != null && result.Data != null) { Trainings=result.Data; }
        }

        public async Task<ServiceResponse<bool>> RegisterTraining(int trainingId)
        {
            var result = await _httpClient.PostAsJsonAsync("api/training/register-training", trainingId);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}

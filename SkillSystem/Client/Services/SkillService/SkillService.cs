using System.Net.Http.Json;

namespace SkillSystem.Client.Services.SkillService
{
    public class SkillService : ISkillService
    {
        private readonly HttpClient _httpClient;

        public SkillService(HttpClient http)
        {
            _httpClient = http;
        }
        public List<SkillLicense> SkillLicenses { get; set; }=new List<SkillLicense>();

        public async Task GetSkillLicense()
        {
            var result =await _httpClient.GetFromJsonAsync<ServiceResponse<List<SkillLicense>>>("api/skill");
            if (result != null && result.Data != null)
            {
                SkillLicenses=result.Data;
            }
        }
    }
}

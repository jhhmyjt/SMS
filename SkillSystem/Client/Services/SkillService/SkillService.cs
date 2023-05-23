using System.Net.Http.Json;

namespace SkillSystem.Client.Services.SkillService
{
    public class SkillService : ISkillService
    {
        private readonly HttpClient _http;

        public SkillService(HttpClient http)
        {
            _http = http;
        }
        public List<SkillLicense> SkillLicenses { get; set; }=new List<SkillLicense>();

        public async Task GetSkillLicense()
        {
            var result =await _http.GetFromJsonAsync<ServiceResponse<List<SkillLicense>>>("api/skill");
            if (result != null && result.Data != null)
            {
                SkillLicenses=result.Data;
            }
        }
    }
}

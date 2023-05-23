using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace SkillSystem.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public UserDetails UserDetails { get; set; }= new UserDetails();

        public async Task<ServiceResponse<bool>> ChangeInfo(UserInfo request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/change-info",request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result=await _httpClient.PostAsJsonAsync("api/auth/change-password",request.Password);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task GetUserDetails()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<UserDetails>>("api/auth/get-user");
            if (result != null && result.Data != null) { UserDetails=result.Data; }
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}

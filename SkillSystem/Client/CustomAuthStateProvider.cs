using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace SkillSystem.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _httpClient;

        public CustomAuthStateProvider(ILocalStorageService localStorage,HttpClient httpClient)
        {
            _localStorage = localStorage;
            _httpClient = httpClient;
        }
        //该方法会从本地存储中获取Token，存储后传递声明并创建新的声明标识，然后通知需要变化的组件
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string authToken = await _localStorage.GetItemAsStringAsync("authToken");

            var identity=new ClaimsIdentity();
            _httpClient.DefaultRequestHeaders.Authorization = null;//用户默认未授权

            if (!string.IsNullOrEmpty(authToken))
            {
                try {
                    identity=new ClaimsIdentity(ParseClaimsFromJwt(authToken),"jwt");
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                        "Bearer",authToken.Replace("\"",""));//删除Token中的引号
                }catch {
                    //方法出错会将认证删除并重新生成一个身份
                    await _localStorage.RemoveItemAsync("authToken");
                    //身份刷新
                    identity = new ClaimsIdentity();
                }
            }

            var user = new ClaimsPrincipal(identity);
            var state=new AuthenticationState(user);

            //通知认证状态改变
            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }
        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2:base64 += "==";break;
                case 3:base64 += "=";break;
            }
            return Convert.FromBase64String(base64);
        }
        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            //分割jwt token
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            var claims = keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));

            return claims;
        }
    }
}

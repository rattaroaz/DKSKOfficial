using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DKSKOfficial.Frontend.Components.Pages.Login.Login;

public class AuthService
{
    private readonly HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TokenResponse> LoginAsync(LoginModel loginModel)
    {
        var content = new StringContent(JsonSerializer.Serialize(loginModel), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("https://localhost:7030/api/Auth/token", content);
        response.EnsureSuccessStatusCode();
        var responseData = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TokenResponse>(responseData);
    }
}


public class LoginModel
{
    public string name { get; set; }
    public string password { get; set; }
}

public class TokenResponse
{
    public string token { get; set; }
}
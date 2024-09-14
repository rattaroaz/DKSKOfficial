using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DKSKOfficial.Frontend.Components.Pages.Login.Login;
using static System.Net.WebRequestMethods;

public class AuthService
{
    private readonly HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> LoginAsync(string name, string password)
    {
        LoginModel loginModel;
        var formContent = new MultipartFormDataContent();
        formContent.Add(new StringContent(name), "username");
        formContent.Add(new StringContent(password), "password");

        var response = await _httpClient.PostAsync(AppConstants.ApiUrl + "/Auth/token", formContent);

        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(responseData);
            return tokenResponse?.token;

        }
        else
        {
            return null;
        }
    }
    // Method to reset password
    public async Task<bool> ResetPasswordAsync(string token, string currentPassword, string newPassword)
    {
        var resetPasswordData = new
        {
            CurrentPassword = currentPassword,
            NewPassword = newPassword
        };
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync(AppConstants.ApiUrl + "/Auth/reset-password", resetPasswordData);

        return response.IsSuccessStatusCode;
    }
}

// Assuming your TokenResponse class looks something like this
public class TokenResponse
{
    public string token { get; set; }  // Modify based on your actual token response structure
    // You can add other properties if needed, such as RefreshToken, Expiry, etc.
}

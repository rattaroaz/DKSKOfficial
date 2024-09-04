using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DKSKOfficial.Frontend.Components.Pages.Login.Login;
using static System.Net.WebRequestMethods;

public class ManagerService
{
    private readonly HttpClient _httpClient;

    public ManagerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Manager>> GetAllCompaniesAsync()
    {
        try
        {
            List<Manager> managers = await _httpClient.GetFromJsonAsync<List<Manager>>(AppConstants.ApiUrl + "/Manager");
            return managers;
        }
        catch (HttpRequestException httpEx)
        {
        }
        catch (Exception ex)
        {
        }
        return null;
    }
  
}

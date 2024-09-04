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

public class SupervisorService
{
    private readonly HttpClient _httpClient;

    public SupervisorService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Supervisor>> GetAllSupervisorsAsync()
    {
        try
        {
            List<Supervisor> supervisors = await _httpClient.GetFromJsonAsync<List<Supervisor>>(AppConstants.ApiUrl + "/Supervisor");
            return supervisors;
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

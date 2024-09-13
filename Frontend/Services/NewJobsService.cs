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

public class JobDescriptionService
{
    private readonly HttpClient _httpClient;

    public JobDescriptionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<JobDiscription>> GetAllJobsAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(AppConstants.ApiUrl +"/JobDescription");
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            List<JobDiscription> Jobs = JsonSerializer.Deserialize<List<JobDiscription>>(responseData) ?? new List<JobDiscription>();
            return Jobs;
        }
        catch (HttpRequestException httpEx)
        {
        }
        catch (Exception ex)
        {
        }
        return null;

    }
    public async Task<bool> ReplaceAll(List<JobDiscription>  jobs)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync(AppConstants.ApiUrl + "/JobDescription/replace", jobs);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                // Successfully replaced job descriptions
                return true;
            }
            else
            {
                // Handle the error
                return false;
            }
            
        }
        catch (HttpRequestException httpEx)
        {
        }
        catch (Exception ex)
        {
        }
        return false;

    }
}

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

    public async Task<List<Job>> GetAllJobsAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(AppConstants.ApiUrl +"/JobDescription");
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            List<Job> Jobs = JsonSerializer.Deserialize<List<Job>>(responseData) ?? new List<Job>();
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
    public async Task<bool> ReplaceAll(List<Job>  jobs)
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
    public class Job
    {
//        public int id { get; set; }
        public string description { get; set; }
        public int sizeBedroom { get; set; }
        public int sizeBathroom { get; set; }
        public int price { get; set; }

    }
}

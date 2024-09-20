using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DKSKOfficial.Frontend.Components.Pages.AgingReports.Agingreports;
using static DKSKOfficial.Frontend.Components.Pages.Login.Login;
using static System.Net.WebRequestMethods;

public class MyCompanyInfoService
{
    private readonly HttpClient _httpClient;

    public MyCompanyInfoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }


    // Retrieves company info from the API
    public async Task<MyCompanyInfo> GetInfoAsync()
    {
        var response = await _httpClient.GetAsync($"{AppConstants.ApiUrl}/MyCompanyInfo");

        if (response.IsSuccessStatusCode)
        {
            // Return the parsed JSON content
            return await response.Content.ReadFromJsonAsync<MyCompanyInfo>();
        }
        else
        {
            // Handle non-success status codes
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Error fetching company info: {errorMessage}");
        }
    }

    // Updates company info by sending a PUT request
    public async Task UpdateInfoAsync(MyCompanyInfo model)
    {
        var url = $"{AppConstants.ApiUrl}/MyCompanyInfo";
        var response = await _httpClient.PutAsJsonAsync(url, model);

        if (!response.IsSuccessStatusCode)
        {
            // Handle error response
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Error updating company info: {errorMessage}");
        }
    }

}

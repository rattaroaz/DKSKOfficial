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

public class ContractorService
{
    private readonly HttpClient _httpClient;

    public ContractorService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Contractor>> GetAllContractorsAsync()
    {
        try
        {
            List<Contractor> contractors = await _httpClient.GetFromJsonAsync<List<Contractor>>(AppConstants.ApiUrl + "/Contractor");
            return contractors;
        }
        catch (HttpRequestException httpEx)
        {
        }
        catch (Exception ex)
        {
        }
        return null;

    }
    public async Task<bool> SaveContractorAsync(Contractor contractor)
    {
       
        try
        {
            HttpResponseMessage response;

            if (contractor.Id == 0) // Assuming Id is the identifier
            {
                // Create new contractor
                response = await _httpClient.PostAsJsonAsync(AppConstants.ApiUrl + "/Contractor", contractor);
            }
            else
            {
                // Update existing contractor
                response = await _httpClient.PutAsJsonAsync(AppConstants.ApiUrl + "/Contractor/" + contractor.Id, contractor);
            }

            if (response.IsSuccessStatusCode)
            {
                // Handle success logic if needed
                return true;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Failed to save contractor. Status Code: {response.StatusCode}, Error: {errorResponse}");
                return false;
            }
        }
        catch (HttpRequestException httpEx)
        {
            // Log the exception details
            Console.WriteLine($"Request error: {httpEx.Message}");
            return false;
        }
        catch (Exception ex)
        {
            // Log the general exception
            Console.WriteLine($"General error: {ex.Message}");
            return false;
        }
    }
    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            // Send the DELETE request to the API
            var response = await _httpClient.DeleteAsync(AppConstants.ApiUrl + "/Contractor/" + id);

            if (response.IsSuccessStatusCode)
            {
                // Return true if the contractor was deleted successfully
                return true;
            }
            else
            {
                // Log the error if the deletion fails
                Console.WriteLine($"Failed to delete contractor. Status Code: {response.StatusCode}");
                return false;
            }
        }
        catch (HttpRequestException httpEx)
        {
            // Log the HttpRequestException
            Console.WriteLine($"Request error: {httpEx.Message}");
            return false;
        }
        catch (Exception ex)
        {
            // Log general exceptions
            Console.WriteLine($"General error: {ex.Message}");
            return false;
        }
    }
}

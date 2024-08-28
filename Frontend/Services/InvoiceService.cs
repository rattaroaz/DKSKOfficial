using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DKSKOfficial.Frontend.Components.Pages.Login.Login;
using static System.Net.WebRequestMethods;

public class InvoiceService
{
    private readonly HttpClient _httpClient;

    public InvoiceService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
    {
        var response = await _httpClient.PostAsJsonAsync(AppConstants.ApiUrl + "/Invoice", invoice);
        response.EnsureSuccessStatusCode(); // Will throw an exception if the status code isn't 2xx

        return await response.Content.ReadFromJsonAsync<Invoice>();
    }
    public async Task<List<Invoice>> GetInvoicesByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        try
        {
            // Construct the URL with query parameters for the date range
            var url = $"{AppConstants.ApiUrl}/Invoice/filter?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";

            // Send the GET request
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Will throw an exception if the status code isn't 2xx

            // Read and deserialize the list of invoices
            var invoices = await response.Content.ReadFromJsonAsync<List<Invoice>>();
            return invoices;
        }
        catch (HttpRequestException httpEx)
        {
            // Handle HTTP-specific exceptions
            // Log the exception or notify the user as needed
            Console.WriteLine($"HTTP Request error: {httpEx.Message}");
            // Optionally, rethrow or handle the exception as needed
            throw;
        }
        catch (JsonException jsonEx)
        {
            // Handle JSON deserialization exceptions
            // Log the exception or notify the user as needed
            Console.WriteLine($"JSON deserialization error: {jsonEx.Message}");
            // Optionally, rethrow or handle the exception as needed
            throw;
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            // Log the exception or notify the user as needed
            Console.WriteLine($"Unexpected error: {ex.Message}");
            // Optionally, rethrow or handle the exception as needed
            throw;
        }
        return new List<Invoice>();
    }

    // Method to update an invoice
    public async Task UpdateInvoiceAsync(int id, Invoice invoice)
    {
        var url = $"{AppConstants.ApiUrl}/Invoice/{id}";
        var response = await _httpClient.PutAsJsonAsync(url, invoice);

        if (!response.IsSuccessStatusCode)
        {
            // Handle error response
            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Error updating invoice: {errorMessage}");
        }
    }

}

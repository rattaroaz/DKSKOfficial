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
    
}

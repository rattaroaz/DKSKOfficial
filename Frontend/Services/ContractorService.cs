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
}

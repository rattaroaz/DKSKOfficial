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

public class CompanyService
{
    private readonly HttpClient _httpClient;

    public CompanyService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Companny>> GetAllCompaniesAsync()
    {
        try
        {
            List<Companny> companies = await _httpClient.GetFromJsonAsync<List<Companny>>(AppConstants.ApiUrl + "/Companny");
            return companies;
        }
        catch (HttpRequestException httpEx)
        {
        }
        catch (Exception ex)
        {
        }
        return null;

    }
  
    public class Companny
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ownner { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string SpecialNote { get; set; }

    }
}

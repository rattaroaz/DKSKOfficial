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

public class PropertiesService
{
    private readonly HttpClient _httpClient;

    public PropertiesService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Properties>> GetPropertiesByCompanyIdAsync(int companyId)
    {
        var response = await _httpClient.GetFromJsonAsync<List<Properties>>(AppConstants.ApiUrl + "/Companny2Property/" + companyId+"/properties");
        return response ?? new List<Properties>();
    }

    public class Properties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string GateCode { get; set; }
        public string LockBox { get; set; }
        public string SpecialNote { get; set; }
    }

}

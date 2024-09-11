using DocumentFormat.OpenXml.ExtendedProperties;
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
            var response = await _httpClient.GetAsync(AppConstants.ApiUrl + "/Companny");

            if (response.IsSuccessStatusCode)
            {
                List<Companny> companies = await response.Content.ReadFromJsonAsync<List<Companny>>();
                return companies;
            }
            else
            {
                Console.WriteLine($"Failed to get companies. Status Code: {response.StatusCode}");
                return new List<Companny>();
            }
        }
        catch (HttpRequestException httpEx)
        {
            // Log the exception details
            Console.WriteLine($"Request error: {httpEx.Message}");
            return new List<Companny>();
        }
        catch (Exception ex)
        {
            // Log the general exception
            Console.WriteLine($"General error: {ex.Message}");
            return new List<Companny>();
        }
    }
    public async Task<bool> SaveCompanyAsync(Companny company)
    {
        CompannyDto compannyDto = new CompannyDto
        {
            Name = company.Name,
            Phone = company.Phone,
            Email = company.Email,
            Address = company.Address,
            City = company.City,
            Zip = company.Zip,
            SpecialNote = company.SpecialNote,
            Supervisors = company.Supervisors?.Select(s => new SupervisorDto
            {
                Name = s.Name,
                Phone = s.Phone,
                Email = s.Email,
                Properties = s.Properties?.Select(p => new PropertyDto
                {
                    Name = p.Name,
                    Address = p.Address,
                    City = p.City,
                    Zip = p.Zip,
                    GateCode = p.GateCode,
                    GarageRemoteCode = p.GarageRemoteCode,
                    ManagerName = p.ManagerName,
                    ManagerPhone = p.ManagerPhone,
                    ManagerEmail = p.ManagerEmail,
                    LockBox = p.LockBox,
                    SpecialNote = p.SpecialNote,
                    IsActive = p.IsActive
                }).ToList()
            }).ToList()
        };
        try
        {
            HttpResponseMessage response;

            if (company.Id == 0) // Assuming Id is the identifier
            {
                // Create new company
                response = await _httpClient.PostAsJsonAsync(AppConstants.ApiUrl + "/Companny", compannyDto);
            }
            else
            {
                // Update existing company
                response = await _httpClient.PutAsJsonAsync(AppConstants.ApiUrl + "/Companny/" + company.Id, compannyDto);
            }

            if (response.IsSuccessStatusCode)
            {
                // Handle success logic if needed
                return true;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Failed to save company. Status Code: {response.StatusCode}, Error: {errorResponse}");
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
    // Delete method for a company
    public async Task<bool> DeleteCompanyAsync(int companyId)
    {
        try
        {
            // Send the DELETE request to the API
            var response = await _httpClient.DeleteAsync(AppConstants.ApiUrl + "/Companny/" + companyId);

            if (response.IsSuccessStatusCode)
            {
                // Return true if the company was deleted successfully
                return true;
            }
            else
            {
                // Log the error if the deletion fails
                Console.WriteLine($"Failed to delete company. Status Code: {response.StatusCode}");
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

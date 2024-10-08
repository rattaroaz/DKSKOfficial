﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
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
    public async Task<List<Properties>> GetAllPropertiesAsync()
    {
        try
        {
            List<Properties> properties = await _httpClient.GetFromJsonAsync<List<Properties>>(AppConstants.ApiUrl + "/Properties");
            return properties;
        }
        catch (HttpRequestException httpEx)
        {
        }
        catch (Exception ex)
        {
        }
        return null;

    }
    public async Task<List<Properties>> GetPropertiesByCompanyIdAsync(int companyId)
    {
        var response = await _httpClient.GetFromJsonAsync<List<Properties>>(AppConstants.ApiUrl + "/Companny2Property/" + companyId+"/properties");
        return response ?? new List<Properties>();
    }
}

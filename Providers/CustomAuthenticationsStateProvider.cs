// /Providers/CustomAuthenticationStateProvider.cs
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Collections.Generic;
namespace DKSKOfficial.Providers
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "authToken");

            var identity = string.IsNullOrEmpty(token) ? new ClaimsIdentity() : ParseToken(token);
            var user = new ClaimsPrincipal(identity);

            return new AuthenticationState(user);
        }

        private ClaimsIdentity ParseToken(string token)
        {
            // Parse token and create ClaimsIdentity
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "user@example.com"),
            new Claim(ClaimTypes.Role, "Admin")
        };

            return new ClaimsIdentity(claims, "jwt");
        }
    }
}

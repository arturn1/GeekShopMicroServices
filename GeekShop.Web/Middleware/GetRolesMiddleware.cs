using GeekShop.Web.Middleware;
using System.Globalization;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace GeekShop.Web.Middleware
{
    public class GetRolesMiddleware
    {
        private readonly RequestDelegate _next;

        public GetRolesMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated && context.User.Claims.FirstOrDefault(x => x.Type == "role")?.Value != null)
            {
                // Get the roles from the Claims of the current user
                var userRoles = context.User.Claims.FirstOrDefault(x => x.Type == "role")?.Value;
                Regex rgx = new Regex("[^a-zA-Z0-9 -,]");
                var clenRoles = rgx.Replace(userRoles, "").Split(',');

                var identityUser = (ClaimsIdentity)context.User.Identity;

                List<Claim> claims = new();

                // Set the roles to the current user
                foreach (var role in clenRoles)
                {
                    var claim = new Claim("role", role.Replace("\"",""));
                    identityUser.AddClaim(claim);
                }

                var claimsTeste = context.User.Identities.First().Claims.ToList();
                var tStringRole = claimsTeste.FirstOrDefault(x => x.Type == "role");

                identityUser.RemoveClaim(tStringRole);

                // Call the next middleware in the pipeline
                await _next(context);
            }
            else
            {
                await _next(context);

            }
        }
    }
}

public static class GetRolesMiddlewareMiddlewareExtensions
{
    public static IApplicationBuilder UseGetRolesMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<GetRolesMiddleware>();
    }
}

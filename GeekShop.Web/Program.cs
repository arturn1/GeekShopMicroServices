using GeekShop.Web.Services.IServices;
using GeekShop.Web.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Reflection.Metadata.Ecma335;
using Microsoft.IdentityModel.Tokens;
using GeekShop.Web.Middleware;
using GeekShopping.Web.Services;

var builder = WebApplication.CreateBuilder(args);

//Add IoC

builder.Services.AddHttpClient<IProductService, ProductService>();
builder.Services.AddHttpClient<ICartService, CartService>();
builder.Services.AddHttpClient<ICouponService, CouponService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "oidc";
})
                .AddCookie("Cookies", c =>
                {
                    c.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                    c.Cookie.SameSite = SameSiteMode.Strict;
                })
                .AddOpenIdConnect("oidc", options =>
                {
                    options.Authority = builder.Configuration["ServiceUrls:IdentityServer"];
                    //options.ClientId = "geek_shopping";
                    options.ClientId = "geek_shoppingComplete";
                    options.ClientSecret = "my_super_secret";
                    options.ResponseType = "code";
                    options.ClaimActions.MapUniqueJsonKey("role", "role", "role");
                    options.ClaimActions.MapUniqueJsonKey("sub", "sub","sub");
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = "name",
                        RoleClaimType = "role"
                    };
                    options.ClaimActions.MapUniqueJsonKey("website", "website");
                    options.ClaimActions.MapUniqueJsonKey("gender", "gender");
                    options.ClaimActions.MapUniqueJsonKey("birthdate", "birthdate");
                    options.ClaimActions.MapUniqueJsonKey("nickname", "nickname");
                    options.Scope.Add("geek_shoppingComplete_scope");
                    //options.Scope.Add("geek_shopping");
                    options.Scope.Add("openid");
                    options.Scope.Add("profile");
                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.SaveTokens = true;
                }
            );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseGetRolesMiddleware();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using GeekShop.React.Services;
using GeekShop.React.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);


//Add IoC

builder.Services.AddHttpClient<IProductService, ProductService>();

// Add services to the container.


//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultScheme = "Cookies";
//    options.DefaultChallengeScheme = "oidc";
//})
//                .AddCookie("Cookies", c =>
//                {
//                    c.ExpireTimeSpan = TimeSpan.FromMinutes(10);
//                    c.Cookie.SameSite = SameSiteMode.Strict;
//                })
//                .AddOpenIdConnect("oidc", options =>
//                {
//                    options.Authority = builder.Configuration["ServiceUrls:IdentityServer"];
//                    options.ClientId = "geek_shopping";
//                    //optionskc.ClientId = "geek_shoppingComplete";
//                    //options.ClientSecret = "my_super_secret";
//                    options.ResponseType = "code";
//                    options.ClaimActions.MapUniqueJsonKey("role", "role");
//                    options.TokenValidationParameters = new TokenValidationParameters
//                    {
//                        NameClaimType = "name",
//                        RoleClaimType = "role"
//                    };
//                    options.ClaimActions.MapUniqueJsonKey("website", "website");
//                    options.ClaimActions.MapUniqueJsonKey("gender", "gender");
//                    options.ClaimActions.MapUniqueJsonKey("birthdate", "birthdate");
//                    options.ClaimActions.MapUniqueJsonKey("nickname", "nickname");
//                    //options.Scope.Add("geek_shoppingComplete_scope");
//                    options.Scope.Add("geek_shopping");
//                    options.Scope.Add("openid");
//                    options.Scope.Add("profile");
//                    options.GetClaimsFromUserInfoEndpoint = true;
//                    options.SaveTokens = true;
//                }
//            );

//builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
//               builder =>
//               {
//                   builder
//                   .WithOrigins("http://localhost:44483/")
//                   .AllowAnyMethod()
//                   .AllowAnyHeader()
//                   .AllowCredentials();
//               }));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//app.UseCors("CorsPolicy");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

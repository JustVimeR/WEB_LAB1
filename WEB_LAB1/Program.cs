using Microsoft.EntityFrameworkCore;
using WEB_LAB1.Models;
using Microsoft.AspNetCore.Identity;
using Google.Apis.Auth.OAuth2;
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = "671378735210-1b6k4phq1cf5or10f2aqgpcqhjeii0lh.apps.googleusercontent.com";
    options.ClientSecret = "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";
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // Add support for Razor Pages

builder.Services.AddDbContext<ProductsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<ProductsIdentityContext>(option => option.UseSqlServer(
builder.Configuration.GetConnectionString("IdentityConnection")
));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ProductsIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages(); // Map Razor Pages
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Products}/{action=Index}/{id?}");
});

app.Run();

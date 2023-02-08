using DataAccess.Data;
using DataAccess.Services;
using DataAccess.Services.Builders;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.ViewModels;
using System.Globalization;
using Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("WebsiteConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Increase Uload Limitation
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 104857600;
});
builder.Services.AddScoped<ServiceSectionFirstStep, ServiceSectionFirstStep>();
builder.Services.AddScoped<ViewModelHomePage, ViewModelHomePage>();
builder.Services.AddScoped<ServiceAdminControl, ServiceAdminControl>();
builder.Services.AddScoped<ServicesHome, ServicesHome>();
builder.Services.AddScoped<BuilderThemMangaer, BuilderThemMangaer>();
builder.Services.AddScoped<BuilderFillData, BuilderFillData>();
builder.Services.AddScoped<EmailSender, EmailSender>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();
builder.Services.AddLocalization(option => option.ResourcesPath = "Resources");
var supportedCulture = new List<CultureInfo>() {
new CultureInfo("en-US"),
new CultureInfo("fa-IR"),
    new CultureInfo("ku-Arab"),
};
var options = new RequestLocalizationOptions()
{
    DefaultRequestCulture = new RequestCulture("ku-Arab"),
    SupportedCultures = supportedCulture,
    SupportedUICultures = supportedCulture,
    RequestCultureProviders = new List<IRequestCultureProvider>()
{
    new QueryStringRequestCultureProvider(),
    new CookieRequestCultureProvider()
}
};
builder.Services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix, options =>
{
    options.ResourcesPath = "Resources";
}).AddDataAnnotationsLocalization(options =>
{
    options.DataAnnotationLocalizerProvider = (Type, factory) =>
    factory.Create(typeof(SharedResources));
});

builder.Services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();

app.UseRequestLocalization(options);
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

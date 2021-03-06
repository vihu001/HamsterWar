using Blazored.LocalStorage;
using HamsterApp.Blazor.ServerUi.Providers;
using HamsterApp.Blazor.ServerUi.Services.Base;
using HamsterApp.Blazor.ServerUi.Services.Authentication;
using HamsterApp.Blazor.ServerUi.LoadImage;
using HamsterApp.Blazor.ServerUi.LoadImage.ILoadImage;
using Microsoft.AspNetCore.Components.Authorization;
using HamsterApp.Blazor.ServerUi.Services;
using HamsterApp.Blazor.ServerUi.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddHttpClient<IClient, Client>(cl => cl.BaseAddress = new Uri("https://localhost:7126"));
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p =>
                p.GetRequiredService<ApiAuthenticationStateProvider>());
builder.Services.AddScoped<IHamsterService, HamsterService>();

builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddScoped<IFileUpload, FileUpload>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

using BlazorCore7WithAdoNet.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using LayerDAL.Setting;
using LayerDAL.Repository;
using BlazorCore7WithAdoNet.Services    ;

namespace BlazorCore7WithAdoNet
{
    // Source: https://www.youtube.com/watch?v=N22gKbrLgK0&t=943s
    // Nået til 4:00 / 18:26
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.Configure<ConnectionSetting>(builder.Configuration.GetSection("ConnectionSetting"));
            builder.Services.AddServerSideBlazor();
            //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepositoryMockData>();
            builder.Services.AddSingleton<WeatherForecastService>();

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
        }
    }
}
using BiletRezervasyon.Business.Abstract;
using BiletRezervasyon.Business.Concrete;
using BiletRezervasyon.Data.Abstract;
using BiletRezervasyon.Data.Concrete.EFcore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiletRezervasyon.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBusRepository, EFCoreBusRepository>();
            services.AddScoped<ITicketRepository, EFCoreTicketRepository>();
            services.AddScoped<IRouteRepository, EFCoreRouteRepository>();
            services.AddScoped<ICityRepository, EFCoreCityRepository>();

            services.AddScoped<IBusService, BusManager>();
            services.AddScoped<ITicketService, TicketManager>();
            services.AddScoped<IRouteService, RouteManager>();
            services.AddScoped<ICityService, CityManager>();


            services.AddControllersWithViews();
            //services.AddRazorPages().AddViewOptions(options =>
            //    options.HtmlHelperOptions.ClientValidationEnabled = false
            //);

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseW3CLogging(); Loglama iþlemleri yapýlmak istendi lakin dotnet 5.0 için uygun deðilmiþ.

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

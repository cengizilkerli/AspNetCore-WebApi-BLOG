using BlogWebApi.WebCore.ApiServices.Concrete;
using BlogWebApi.WebCore.ApiServices.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlogWebApi.WebCore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddHttpClient<IBlogApiService, BlogApiManager>();
            services.AddHttpClient<ICategoryApiService, CategoryApiManager>();
            services.AddHttpClient<IImageApiService, ImageApiManager>();
            services.AddHttpClient<IAuthApiService, AuthApiManager>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSession();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{controller=Blog}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
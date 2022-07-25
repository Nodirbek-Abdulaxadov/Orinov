using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orinov.Data.Repositories;
using Orinov.Domain.Interfaces;

namespace Orinov.Application
{
    public static class AppConfiguration
    {
        public static void AddDIContainers(this IServiceCollection services)
        {
            services.AddTransient<IAnnouncementInterface, AnnouncementRepository>();
            services.AddTransient<IPublicationInterface, PublicationRepository>();
            services.AddTransient<IPersonalInfoInterface, PersonalInfoRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static void AddServiceConfigurations(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static void AddApplicationMiddlewares(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}

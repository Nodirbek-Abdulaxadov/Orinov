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
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static void AddServiceConfigurations(this IServiceCollection services)
        {
            services.AddControllers();
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

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}

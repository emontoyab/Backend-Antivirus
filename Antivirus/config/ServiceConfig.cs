using Microsoft.EntityFrameworkCore;
using Antivirus.Services;
using Antivirus.Models;

namespace Antivirus.config
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Inyección de dependencias
            services.AddScoped<AuthService>();
            services.AddScoped<ICostsBootcampService, CostBootcampService>();
            services.AddScoped<IStatusOpportunitiesService, StatusOpportunitiesService>();
            
            // Configuración de la base de datos
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}

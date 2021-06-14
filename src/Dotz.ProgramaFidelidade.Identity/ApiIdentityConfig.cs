using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Identity;
using NetDevPack.Identity.Jwt;

namespace Dotz.ProgramaFidelidade.Identity
{
    public static class ApiIdentityConfig
    {
        public static void AddApiIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentityEntityFrameworkContextConfiguration(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Dotz.ProgramaFidelidade.Identity")));

            services.AddIdentityConfiguration();

            services.AddJwtConfiguration(configuration, "AppSettings");
        }
    }
}

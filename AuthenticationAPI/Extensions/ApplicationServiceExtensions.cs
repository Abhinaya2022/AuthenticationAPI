using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            string? connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<IdentityDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddControllers();

            return services;
        }


        public static IApplicationBuilder UseApplicationServices(this IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline.           

            app.UseHttpsRedirection();

            app.UseAuthorization();

            return app;
        }
    }
}

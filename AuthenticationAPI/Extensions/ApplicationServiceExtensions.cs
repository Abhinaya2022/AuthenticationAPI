namespace AuthenticationAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
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

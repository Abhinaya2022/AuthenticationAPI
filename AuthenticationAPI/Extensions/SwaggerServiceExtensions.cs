﻿namespace AuthenticationAPI.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentiation(this IServiceCollection services)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            return services;
        }

        public static IApplicationBuilder UseSwagerDocumentationUI(this IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline.

            app.UseSwagger();
            app.UseSwaggerUI();

            return app;

        }
    }
}

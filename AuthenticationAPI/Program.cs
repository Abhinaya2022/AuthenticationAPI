using AuthenticationAPI.Extensions;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddApplicationServices(builder.Configuration);
        builder.Services.AddSwaggerDocumentiation();



        var app = builder.Build();

        app.UseApplicationServices();
        app.UseSwagerDocumentationUI();

        app.MapControllers();

        app.Run();
    }
}
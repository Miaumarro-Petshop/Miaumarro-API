using MiauAPI.Services;
using MiauDatabase.Extensions;

namespace MiauAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        // Add IoC services
        builder.Services    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            .AddEndpointsApiExplorer()
            .AddSwaggerGen()
            .AddScoped<UserService>()
            .AddMiauDb();   // Add Miau database context

        var app = builder.Build();

        // Configure the HTTP request pipeline.
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
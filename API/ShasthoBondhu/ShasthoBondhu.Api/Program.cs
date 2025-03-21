using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Data;
using ShasthoBondhu.Service.Interfaces;
using ShasthoBondhu.Service.Services;
using System.Reflection;

internal static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        builder.Services.AddDbContext<ShasthoBondhuDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ShasthoBondhuDbContext")));

        builder.Services.AddScoped<IShasthoBondhuDbContext, ShasthoBondhuDbContext>();

        builder.Services.AddScoped<IPatientService, PatientService>();

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

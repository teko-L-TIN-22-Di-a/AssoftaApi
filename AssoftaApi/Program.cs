
using AssoftaApi.Database;
using AssoftaApi.Services;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AssoftaDbContext>(options =>
                options.UseInMemoryDatabase("assofta"));

            builder.Services.AddScoped<AntragService>();
            builder.Services.AddScoped<SchadensmeldungService>();
            builder.Services.AddScoped<BenutzerService>();
            builder.Services.AddScoped<PoliceService>();
            builder.Services.AddScoped<FakturaService>();
            builder.Services.AddScoped<CRMService>();
            builder.Services.AddScoped<SchadensregulierungService>();



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
}

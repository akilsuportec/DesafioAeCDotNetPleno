using ClimaAPI.Data;
using ClimaAPI.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ClimaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IClimaAPIRepositorio, ClimaAPIRepositorio>();

            builder.Services.AddEntityFrameworkSqlServer()
            .AddDbContext<ClimaAPIDBContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );             

            builder.Services.AddHttpClient("BrasilAPI", client =>
            {
                client.BaseAddress = new Uri("https://brasilapi.com.br/");
            });

            var app = builder.Build();

            
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
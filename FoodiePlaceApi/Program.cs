
using FoodiePlaceApi.Authentication;
using FoodiePlaceApi.DAL;
using Microsoft.EntityFrameworkCore;

namespace FoodiePlaceApi
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

            builder.Services.AddDbContextFactory<Contexto>
                (o => o.UseSqlite(builder.Configuration.GetConnectionString("ConStr")));

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{

            //}

            app.UseHttpsRedirection();

            app.UseMiddleware<ApiKeyAuthMiddleware>();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

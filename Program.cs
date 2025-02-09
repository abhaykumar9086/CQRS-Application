
using ECommerceApp.Application.CommandHandlers;
using ECommerceApp.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add DbContext with connectionString.
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("ECommerceDB"));
            // Add MediatR
            builder.Services.AddMediatR(typeof(CreateOrderHandler).Assembly);
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

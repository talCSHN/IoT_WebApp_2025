
using Microsoft.EntityFrameworkCore;
using WebApiApp01.Models;

namespace WebApiApp01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // CORS 설정
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:5080")  // 프론트엔드(본인포트번호) 주소
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            // DB연결 설정 초기화 로직
            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseMySql(
                    builder.Configuration.GetConnectionString("SmartHomeConnection"),
                    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("SmartHomeConnection"))
                )
            );

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseCors("AllowFrontend");  // CORS 설정 사용

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

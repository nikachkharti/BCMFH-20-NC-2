using Microsoft.EntityFrameworkCore;
using University.API.Middleware;
using University.Repository.Data;
using University.Repository.Implementations;
using University.Repository.Interfaces;
using University.Service.Implementations;
using University.Service.Interfaces;
using University.Service.Mapping;

namespace University.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.AddControllers();
            builder.AddOpenApi();
            builder.AddDatabase();
            builder.AddAutoMapper();
            builder.AddRepositories();

            builder.ConfigureJwtOptions();
            builder.AddIdentity();
            builder.AddAuthentication();
            builder.AddJwtTokenGenerator();
            builder.AddServices();
            builder.AddAuthService();

            var app = builder.Build();

            app.CreateDatabaseAutomatically();
            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.MapOpenApi();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using University.Repository.Data;
using University.Repository.Implementations;
using University.Repository.Interfaces;

namespace University.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            builder.Services
                .AddDbContext<ApplicationDbContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection")));

            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();

            var app = builder.Build();

            app.MapOpenApi();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}

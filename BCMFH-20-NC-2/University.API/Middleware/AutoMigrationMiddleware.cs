using University.Repository.Data;

namespace University.API.Middleware
{
    public static class AutoMigrationMiddleware
    {
        public static void CreateDatabaseAutomatically(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                try
                {
                    var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
                    context.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured while app initialization {ex}");
                }

            }

        }
    }
}

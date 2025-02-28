namespace Example.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Singleton - ნიშნავს რომ რეგისტრირებული სერვისის მხოლოდ 1 ინსტანსი მოემსახურება მთელს აპლიკაციას, სანამ აპლიკაცია აქტიურია. ყველაზე სიცოცხლისუნარიანი
            //builder.Services.AddSingleton<IStudentService, StudentService>();

            //Scoped - ყოველი ახალი ინსტანსი იქმნება მხოლოდ კონკრეტული  scope - ის შიგნით. საშუალოდ სიცოცხლისუნარიანი.
            //builder.Services.AddScoped<IStudentService, StudentService>();

            //Transient - ნიშნავს რომ ყოველ ჯერზე სერვისის გამოყენებისას ძველი ინსტანსი განადგურდება (Dispose) ახალი ინსტანსი შეიქმენბა.ყველაზე ხანმოკლე სიცოცხლის მქონე.
            //builder.Services.AddTransient<IStudentService, StudentService>();

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

using Microsoft.Extensions.Logging;
using POLICLINICA_HOPE_.Data; // Namespace-ul în care se află AppDbContext și SeedData
using Microsoft.Extensions.DependencyInjection;

namespace POLICLINICA_HOPE_
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Înregistrăm AppDbContext pentru Dependency Injection
            builder.Services.AddDbContext<AppDbContext>();

            var app = builder.Build();

            // Populăm baza de date cu SeedData
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated(); // Creează baza de date dacă nu există
                SeedData.Initialize(context);    // Populează baza de date
            }

            return app;
        }
    }
}

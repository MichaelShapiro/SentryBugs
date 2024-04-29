using Microsoft.Extensions.Logging;

namespace UserInfoMissing
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
                })
                .UseSentry(sentryOptions =>
                {
                    sentryOptions.Dsn = ">>>>>>>>>>>>>>>> SET YOUR URL HERE <<<<<<<<<<<<<<<<<<";
                    sentryOptions.Environment = "development";
                });


#if DEBUG
    		builder.Logging.AddDebug();
#endif


            return builder.Build();
        }
    }
}

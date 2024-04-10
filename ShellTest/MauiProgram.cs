using Microsoft.Extensions.Logging;
using ShellTest.MVVM.Pages;
using ShellTest.MVVM.Pages.Zona;
using ShellTest.MVVM.ViewModels;

namespace ShellTest
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

            builder.Services.AddTransient<NewPage1>();
            builder.Services.AddTransient<NewPage2>();
           
            builder.Services.AddTransient<AppShell>();

            builder.Services.AddTransient<TestViewModel>();

            return builder.Build();
        }
    }
}

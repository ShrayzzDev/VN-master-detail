using CommunityToolkit.Maui;
using Interfaces;
using Microsoft.Extensions.Logging;
using Stub;
using ViewModel;

namespace VN_master_detail
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddScoped<BasicNovelListVM>();

            builder.Services.AddScoped<AcceuilPage>();
            builder.Services.AddScoped<Search>();

            builder.Services.AddScoped<IDataManager, DataManager>();
            builder.Services.AddScoped<INovelRequestor, NovelStub>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

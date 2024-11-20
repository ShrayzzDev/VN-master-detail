using CommunityToolkit.Maui;
using Interfaces;
using Microsoft.Extensions.Logging;
using Model;
using Stub;
using ViewModel;
using ViewModel.Novels;

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

            builder.Services.AddScoped<BaseNovelListVM>();
            builder.Services.AddScoped<UserVM>();

            builder.Services.AddScoped<AcceuilPage>();
            builder.Services.AddScoped<Profile>();
            builder.Services.AddScoped<Search>();
            builder.Services.AddScoped<Login>();

            builder.Services.AddSingleton<IDataManager<User>, DataManagers.DataManager>();
            builder.Services.AddScoped<INovelRequestor, NovelStub>();
            builder.Services.AddScoped<IUserRequestor, UserStub>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

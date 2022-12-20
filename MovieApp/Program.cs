using Microsoft.Extensions.DependencyInjection;
using MovieApp.MovieAppData;
using IgniteUI.Blazor.Controls;

public class MovieAppShared
{
    public static void Register(IServiceCollection services)
    {
        services.AddScoped<MovieAppDataService>();
        RegisterIgniteUI(services);
    }

    public static void RegisterIgniteUI(IServiceCollection services)
    {
        services.AddIgniteUIBlazor(
            typeof(IgbNavDrawerModule),
            typeof(IgbRippleModule),
            typeof(IgbIconButtonModule),
            typeof(IgbAvatarModule),
            typeof(IgbDropdownModule),
            typeof(IgbDropdownItemModule),
            typeof(IgbButtonModule),
            typeof(IgbTabsModule),
            typeof(IgbCardModule),
            typeof(IgbDatePickerModule),
            typeof(IgbListModule)
        );
    }
}
﻿global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Maui;
global using Microsoft.Extensions.Logging;
global using SprintathonLaundryApp.ViewModels;
global using SprintathonLaundryApp.Views;
global using CommunityToolkit.Mvvm.Input;
namespace SprintathonLaundryApp;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

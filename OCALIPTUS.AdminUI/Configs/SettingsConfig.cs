using System.Globalization;
using FluentValidation;
using OCALIPTUS.Application.Common.Managers;
using OCALIPTUS.Application.Common.Models;

namespace OCALIPTUS.AdminUI.Configs;

public static class SettingsConfig
{
    public static IServiceCollection AddSettingsConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var cultureInfo = new CultureInfo("tr-TR");
        System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
        ValidatorOptions.Global.LanguageManager.Culture = cultureInfo;
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

        services.Configure<TokenSetting>(configuration.GetSection("TokenSetting"));
        services.AddTransient<TokenManager>();
        services.AddTransient<FileManager>();
        return services;
    }
}
﻿using Blazored.LocalStorage;
using FormiWebshop.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;

public static class WebAssemblyHostExtensions
{
    public async static Task SetDefaultCulture(this WebAssemblyHost host)
    {
        var localStorage = host.Services.GetRequiredService<ILocalStorageService>();
        var cultureString = await localStorage.GetItemAsync<string>("culture");

        CultureInfo cultureInfo;

        if (!string.IsNullOrWhiteSpace(cultureString))
        {
            cultureInfo = new CultureInfo(cultureString);
        }
        else
        {
            cultureInfo = new CultureInfo(LocalizerSettings.NeutralCulture.Name);
        }

        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    }
}
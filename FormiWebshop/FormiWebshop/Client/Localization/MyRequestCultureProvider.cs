﻿using System.Globalization;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;

namespace FormiWebshop.Client.Localization
{
    public class MyRequestCultureProvider : RequestCultureProvider
    {
        private readonly string _defaultLanguage;
        private string? _selectedLanguage;

        public MyRequestCultureProvider(string defaultLanguage)
        {
            _defaultLanguage = defaultLanguage;
        }
        private string? GetLanguageFromUrl(string url)
        {
            var uri = new Uri(url);
            var urlParameters = HttpUtility.ParseQueryString(uri.Query);
            return urlParameters["language"];
        }

        public override Task<ProviderCultureResult?> DetermineProviderCultureResult(HttpContext httpContext)
        {
            if (httpContext.Request.Headers["Sec-Fetch-Dest"] == "document")
            {
                string url = httpContext.Request.GetDisplayUrl();
                _selectedLanguage = GetLanguageFromUrl(url);

                if (string.IsNullOrEmpty(_selectedLanguage))
                {
                    _selectedLanguage = _defaultLanguage;
                }

                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(_selectedLanguage);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(_selectedLanguage);
                var result = new ProviderCultureResult(_selectedLanguage);

                return Task.FromResult<ProviderCultureResult?>(result);
            }
            else
            {
                return Task.FromResult<ProviderCultureResult?>(new ProviderCultureResult(_selectedLanguage));
            }
        }
    }
}

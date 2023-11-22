using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Resources;

namespace FormiWebshop.Client.Localization
{
    public class MyStringLocalizer<TComponent> : IStringLocalizer<TComponent>
    {
        public LocalizedString this[string name] => FindLocalizedString(name);
        public LocalizedString this[string name, params object[] arguments] => FindLocalizedString(name, arguments);

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new NotImplementedException();
        }

        private readonly IOptions<LocalizationOptions> _localizationOptions;

        public MyStringLocalizer(IOptions<LocalizationOptions> localizationOptions)
        {
            _localizationOptions = localizationOptions;
        }

        private LocalizedString FindLocalizedString(string key, object[]? arguments = default)
        {
            var resourceManager = CreateResourceManager();
            LocalizedString result;

            try
            {
                string value = resourceManager.GetString(key);

                if (arguments is not null)
                {
                    value = string.Format(value, arguments);
                }

                result = new(key, value, false, GetResourceLocation());
            }
            catch
            {
                result = new(key, "", true, GetResourceLocation());
            }

            return result;
        }

        private ResourceManager CreateResourceManager()
        {
            string resourceLocation = GetResourceLocation();
            var resourceManager = new ResourceManager(resourceLocation, Assembly.GetExecutingAssembly());

            return resourceManager;
        }

        private string GetResourceLocation()
        {
            var componentType = typeof(TComponent);
            var nameParts = componentType.FullName.Split('.').ToList();
            nameParts.Insert(1, _localizationOptions.Value.ResourcesPath);
            string resourceLocation = string.Join(".", nameParts);

            return resourceLocation;
        }
    }
}

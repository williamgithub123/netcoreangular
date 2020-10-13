using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Eduardoproyect.Localization
{
    public static class EduardoproyectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EduardoproyectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EduardoproyectLocalizationConfigurer).GetAssembly(),
                        "Eduardoproyect.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

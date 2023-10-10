using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyApp;

[Dependency(ReplaceServices = true)]
public class MyAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyApp";
}

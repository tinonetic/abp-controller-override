using Volo.Abp.Modularity;

namespace MyApp;

[DependsOn(
    typeof(MyAppApplicationModule),
    typeof(MyAppDomainTestModule)
    )]
public class MyAppApplicationTestModule : AbpModule
{

}

using MyApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyApp;

[DependsOn(
    typeof(MyAppEntityFrameworkCoreTestModule)
    )]
public class MyAppDomainTestModule : AbpModule
{

}

using MyApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyAppEntityFrameworkCoreModule),
    typeof(MyAppApplicationContractsModule)
    )]
public class MyAppDbMigratorModule : AbpModule
{

}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyApp.Data;

/* This is used if database provider does't define
 * IMyAppDbSchemaMigrator implementation.
 */
public class NullMyAppDbSchemaMigrator : IMyAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

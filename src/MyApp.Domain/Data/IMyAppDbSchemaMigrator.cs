using System.Threading.Tasks;

namespace MyApp.Data;

public interface IMyAppDbSchemaMigrator
{
    Task MigrateAsync();
}

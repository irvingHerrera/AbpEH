using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TetstEH.Data;

/* This is used if database provider does't define
 * ITetstEHDbSchemaMigrator implementation.
 */
public class NullTetstEHDbSchemaMigrator : ITetstEHDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

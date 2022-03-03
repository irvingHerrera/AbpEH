using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TetstEH.Data;
using Volo.Abp.DependencyInjection;

namespace TetstEH.EntityFrameworkCore;

public class EntityFrameworkCoreTetstEHDbSchemaMigrator
    : ITetstEHDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTetstEHDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TetstEHDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TetstEHDbContext>()
            .Database
            .MigrateAsync();
    }
}

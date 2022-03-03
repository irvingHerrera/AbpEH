using TetstEH.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TetstEH.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TetstEHEntityFrameworkCoreModule),
    typeof(TetstEHApplicationContractsModule)
    )]
public class TetstEHDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}

using TetstEH.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TetstEH;

[DependsOn(
    typeof(TetstEHEntityFrameworkCoreTestModule)
    )]
public class TetstEHDomainTestModule : AbpModule
{

}

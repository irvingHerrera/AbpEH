using Volo.Abp.Modularity;

namespace TetstEH;

[DependsOn(
    typeof(TetstEHApplicationModule),
    typeof(TetstEHDomainTestModule)
    )]
public class TetstEHApplicationTestModule : AbpModule
{

}

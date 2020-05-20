using Volo.Abp.Modularity;

namespace PwaTest
{
    [DependsOn(
        typeof(PwaTestApplicationModule),
        typeof(PwaTestDomainTestModule)
        )]
    public class PwaTestApplicationTestModule : AbpModule
    {

    }
}
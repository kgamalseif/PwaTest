using PwaTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PwaTest
{
    [DependsOn(
        typeof(PwaTestEntityFrameworkCoreTestModule)
        )]
    public class PwaTestDomainTestModule : AbpModule
    {

    }
}
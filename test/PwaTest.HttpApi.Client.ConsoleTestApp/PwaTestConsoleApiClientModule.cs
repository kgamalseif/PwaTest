using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace PwaTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(PwaTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PwaTestConsoleApiClientModule : AbpModule
    {
        
    }
}

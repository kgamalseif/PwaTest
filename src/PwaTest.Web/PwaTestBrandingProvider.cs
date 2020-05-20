using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace PwaTest.Web
{
    [Dependency(ReplaceServices = true)]
    public class PwaTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PwaTest";
    }
}

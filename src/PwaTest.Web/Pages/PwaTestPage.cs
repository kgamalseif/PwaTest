using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using PwaTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PwaTest.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits PwaTest.Web.Pages.PwaTestPage
     */
    public abstract class PwaTestPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<PwaTestResource> L { get; set; }
    }
}

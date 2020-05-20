using PwaTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PwaTest.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class PwaTestPageModel : AbpPageModel
    {
        protected PwaTestPageModel()
        {
            LocalizationResourceType = typeof(PwaTestResource);
        }
    }
}
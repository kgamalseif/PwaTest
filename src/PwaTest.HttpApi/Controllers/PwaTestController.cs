using PwaTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PwaTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PwaTestController : AbpController
    {
        protected PwaTestController()
        {
            LocalizationResource = typeof(PwaTestResource);
        }
    }
}
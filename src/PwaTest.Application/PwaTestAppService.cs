using System;
using System.Collections.Generic;
using System.Text;
using PwaTest.Localization;
using Volo.Abp.Application.Services;

namespace PwaTest
{
    /* Inherit your application services from this class.
     */
    public abstract class PwaTestAppService : ApplicationService
    {
        protected PwaTestAppService()
        {
            LocalizationResource = typeof(PwaTestResource);
        }
    }
}

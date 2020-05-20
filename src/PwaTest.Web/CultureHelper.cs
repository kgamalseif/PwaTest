using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Localization
{
    public static class CultureHelper
    {
        public static bool IsRtl
        {
            get { return CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Localization;
using Volo.Abp.Application.Services;

namespace MyApp;

/* Inherit your application services from this class.
 */
public abstract class MyAppAppService : ApplicationService
{
    protected MyAppAppService()
    {
        LocalizationResource = typeof(MyAppResource);
    }
}

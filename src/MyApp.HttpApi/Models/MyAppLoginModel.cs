using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Account.Web;
using Volo.Abp.Account.Web.Pages.Account;
using Volo.Abp.DependencyInjection;

namespace MyApp.Models
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(LoginModel), IncludeSelf = true)]
    public class MyAppLoginModel : LoginModel
    {
        public MyAppLoginModel(IAuthenticationSchemeProvider schemeProvider, IOptions<AbpAccountOptions> accountOptions, IOptions<IdentityOptions> identityOptions) : base(schemeProvider, accountOptions, identityOptions)
        {
        }

        public override async Task<IActionResult> OnPostAsync(string action)
        {
            var result = await base.OnPostAsync(action);
            if (Alerts.Any(a => a.Title == "UserLockedOutMessage"))
            {
                Alerts.Clear();
                Alerts.Danger(L["InvalidUserNameOrPassword"]);
            }
            return result;
        }
    }
}

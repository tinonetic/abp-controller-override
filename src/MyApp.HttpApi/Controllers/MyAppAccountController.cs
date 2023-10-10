using Volo.Abp.DependencyInjection;
using Volo.Abp.Account.Web.Areas.Account.Controllers;
using Volo.Abp.Account.Web.Areas.Account.Controllers.Models;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Identity;
using Volo.Abp.Settings;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MyApp.Controllers
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(AccountController))]
    public class MyAppAccountController : AccountController
    {
        public MyAppAccountController(SignInManager<Volo.Abp.Identity.IdentityUser> signInManager, IdentityUserManager userManager, ISettingProvider settingProvider, IdentitySecurityLogManager identitySecurityLogManager, IOptions<IdentityOptions> identityOptions) 
            : base(signInManager, userManager, settingProvider, identitySecurityLogManager, identityOptions)
        {
        }

        public override async Task<AbpLoginResult> Login(Volo.Abp.Account.Web.Areas.Account.Controllers.Models.UserLoginInfo login)
        {
            Logger.LogInformation("#### Working");
            var loginResult = await base.Login(login);
            if (loginResult.Result == LoginResultType.LockedOut)
            {
                return new AbpLoginResult(LoginResultType.InvalidUserNameOrPassword);
            }
            return loginResult;
        }
    }
}

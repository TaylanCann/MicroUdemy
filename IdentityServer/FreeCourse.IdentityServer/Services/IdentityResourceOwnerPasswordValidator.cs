using FreeCourse.IdentityServer.Models;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.IdentityServer.Services
{
    public class IdentityResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityResourceOwnerPasswordValidator(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var existUser = await _userManager.FindByEmailAsync(context.UserName);

            if (existUser != null)
            {
               var errors = new Dictionary<string, object>();
                errors.Add("errors", new List<string> { "Kullanıcı adı veya şifre yanlış" });
            }

        }
    }
}

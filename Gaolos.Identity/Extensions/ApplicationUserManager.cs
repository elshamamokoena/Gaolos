using Gaolos.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Identity.Extensions
{
    public class ApplicationUserManager: UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<ApplicationUser> passwordHasher, 
            IEnumerable<IUserValidator<ApplicationUser>> userValidators, 
            IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, 
            ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<ApplicationUser>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
        public async Task SetNameAsync(ApplicationUser user, string name)
        {
            user.Name = name;
            await UpdateAsync(user);
        }
        public async Task SetSurnameAsync(ApplicationUser user, string surname)
        {
            user.Surname = surname;
            await UpdateAsync(user);
        }
        //public async Task SetPhoneNumberAsync(ApplicationUser user, string phone)
        //{
        //    user.PhoneNumber = phone;
        //    await UpdateAsync(user);
        //}
        //public async Task<string?> GetPhoneNumberAsync(ApplicationUser user)
        //{
        //    return await Task.FromResult(user.PhoneNumber);
        //}
        public async Task<string?> GetNameAsync(ApplicationUser user)
        {
            return await Task.FromResult(user.Name);
        }
        public async Task<string?> GetSurnameAsync(ApplicationUser user)
        {
            return await Task.FromResult(user.Surname);
        }
       // public async Task<string?> GetNameIdentifier



    }
}

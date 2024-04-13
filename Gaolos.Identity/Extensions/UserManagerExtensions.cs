using Gaolos.Identity.Data;
using Gaolos.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Identity.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<InfoResponse> GetInfoAsync(this UserManager<ApplicationUser> userManager, string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return null;
            }

            return new InfoResponse
            {
                UserId = user.Id,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                IsEmailConfirmed = user.EmailConfirmed
            };
        }
    }
}

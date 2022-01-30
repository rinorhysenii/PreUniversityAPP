using Application.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInMenager;
        public AccountRepository(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInMenager = signInManager;
        }

        public async Task Login(RegisterViewModel loguser)
        {

            AppUser user =  await _userManager.FindByEmailAsync(loguser.Email);

             await _signInMenager.SignInAsync(user, isPersistent: false, authenticationMethod: null);

           
         
        }

        public async Task LogOut()
        {
            await _signInMenager.SignOutAsync();
        }

        public async Task<bool> Register(RegisterViewModel user)
        {
            AppUser useri = new AppUser() {

                Email = user.Email,
                UserName=user.NickName,
                PasswordHash=user.Password,

            };
            var resault = await _userManager.CreateAsync(useri);

            if (resault.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

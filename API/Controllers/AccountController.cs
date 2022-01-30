using Application.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
   
    public class AccountController : BaseApiController
    {
        public readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel user)
        {
            var resault = await _accountRepository.Register(user);
            if (resault == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("/login")]
        public async Task<IActionResult> Login(RegisterViewModel login)
        {
            await  _accountRepository.Login(login);
            if (User.Identity.IsAuthenticated)
            {
                return Ok();
            
            }
            else
            {
                return BadRequest();
            }
            

        }
        [HttpPost("/logout")]

        public async Task<IActionResult> Logout()
        {
            await _accountRepository.LogOut();

            if (!User.Identity.IsAuthenticated)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.Model;
using Authentication.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly SignInManager<BusinessUser> _signInManager;
        public AuthController(SignInManager<BusinessUser> signInManager)
        {
            _signInManager = signInManager;
        }

        // POST: /api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]LoginViewModel vm)
        {
            // Validate the requests
            if (!ModelState.IsValid)
            {
                return BadRequest(); // TODO: Return error description
            }

            return Ok();

            //var result = await _signInManager.PasswordSignInAsync(
            //    userName: vm.Username,
            //    password: vm.Password,
            //    isPersistent: true, // TODO: Get this from the viewmodel
            //    lockoutOnFailure: true
            //);

            //if (result.RequiresTwoFactor)
            //{
            //    return StatusCode(StatusCodes.Status501NotImplemented);
            //}
            //if (result.IsLockedOut)
            //{
            //    return StatusCode(StatusCodes.Status423Locked);
            //}
            //if (result.Succeeded)
            //{
            //    return Ok();
            //}

            //return Unauthorized();
        }

        // POST: /api/auth/logout
        [Authorize, HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

    }
}
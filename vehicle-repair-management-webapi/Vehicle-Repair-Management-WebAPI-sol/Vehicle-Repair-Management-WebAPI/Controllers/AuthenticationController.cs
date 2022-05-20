using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Repair_Management_WebAPI.ViewModel.Authentication;

namespace Vehicle_Repair_Management_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        UserManager<IdentityUser> _userManager;
        IConfiguration _configuration;
        public AuthenticationController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("/api/authentication/register")]
        public async Task<IActionResult> Register([FromBody] RegistrationViewModel registrationViewModel)
        {

            var userExists = await _userManager.FindByNameAsync(registrationViewModel.UserName);
            if (userExists != null)
            {
                return Ok(new { statusCode = 500, Message = "User name already exists" });
            }

            IdentityUser user = new IdentityUser
            {
                UserName = registrationViewModel.UserName,
                Email = registrationViewModel.Email
            };



            var result = await _userManager.CreateAsync(user, registrationViewModel.Password);
            if (!result.Succeeded)
            {
                return Ok(new 
                {
                    statusCode = 500,Message = "Password is Too Simple !! Please Choose Another !!"
                    
                });
            }

            return Ok(new { statusCode=200,Message = "User Created Successfully" });
        }

        [HttpPost]
        [Route("/api/authentication/login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                if(await _userManager.CheckPasswordAsync(user, loginViewModel.Password))
                {
                    List<Claim> userClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName)
                };


                    var signInKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                    var jwtSecurityToken = new JwtSecurityToken(
                        issuer: _configuration["JWT:ValidIssuer"],
                        audience: _configuration["JWT:ValidAudience"],
                        expires: DateTime.Now.AddHours(1),
                        claims: userClaims,
                        signingCredentials: new SigningCredentials(signInKey, SecurityAlgorithms.HmacSha256)
                        );

                    return Ok(new
                    {
                        statusCode = 200,
                        token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                        expiration = jwtSecurityToken.ValidTo
                    });
                }
                return Ok(new { statusCode = 403, message = "Wrong password" });
            }

            return Ok(new { statusCode=404, message="User not found" });


        }
    }


}


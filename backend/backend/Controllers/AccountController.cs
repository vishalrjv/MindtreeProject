using backend.Dtos;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Http;
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

namespace backend.Controllers
{
    
    public class AccountController : BaseController
    {
        private readonly IUnitOfWork uow;
        private readonly IConfiguration configuration;
        public AccountController(IUnitOfWork uow,IConfiguration configuration )
        {
            this.configuration = configuration;
            this.uow = uow;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginReqDto loginReq)
        {
            var user = await uow.UserRepository.Authenticate(loginReq.EmailId, loginReq.Password);
            if (user == null)
            {
                return Unauthorized("Invalid emailid or password");
            }
            var loginRes = new LoginResDto();
            loginRes.EmailId = user.EmailId;
            loginRes.Token = CreateJWT(user);
            return Ok(loginRes);

            //var user = await uow.UserRepository.Authenticate(loginReq.EmailId, loginReq.Password);
            //if (user == null)
            //{
            //    return Unauthorized();
            //}
            //var loginRes =new LoginResDto();
            //loginRes.EmailId = user.EmailId;
            //loginRes.Token = CreateJWT(user);
            // return Ok(loginRes); 

        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(LoginReqDto loginReq)
        {
            

           

            if (await uow.UserRepository.UserAlreadyExists(loginReq.EmailId))
            {
                
                return BadRequest("User already exists, please try different emailid");
            }

            uow.UserRepository.Register(loginReq.EmailId, loginReq.Password);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        private string CreateJWT(userloginnew user)
        {
            var secretKey = configuration.GetSection("AppSettings:Key").Value;
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(secretKey));
            var claims = new Claim[] {
                new Claim(ClaimTypes.Name,user.EmailId),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };
            var signingCredentials = new SigningCredentials(
                   key, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = signingCredentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

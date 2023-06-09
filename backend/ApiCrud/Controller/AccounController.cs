using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ApiCrud.Controllers;
using ApiCrud.Dtos.UserDtos;
using ApiCrud.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ApiCrud.Controller;


public class AccountController : BaseController
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IConfiguration _configuration;

    public AccountController(UserManager<AppUser> userManager,IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

     [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        var user = await _userManager.FindByNameAsync(registerDto.UserName);
        if (user != null) return StatusCode(409);

        
        AppUser appUser = new AppUser();
        appUser.Fullname=registerDto.Fullname;
        appUser.UserName=registerDto.UserName;

        var result = await _userManager.CreateAsync(appUser,registerDto.Password);
        if(!result.Succeeded) return BadRequest(result.Errors);
        result = await _userManager.AddToRoleAsync(appUser,"Member");
        if(!result.Succeeded) return BadRequest(result.Errors);

        return StatusCode(201);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await _userManager.FindByNameAsync(loginDto.UserName);
        if(user==null) return NotFound();
        if(!await _userManager.CheckPasswordAsync(user,loginDto.Password)) return NotFound();

        //generate token
        var tokenHandler = new JwtSecurityTokenHandler();
		var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]);
	    
        var claimList = new List<Claim>
        {
            new Claim(ClaimTypes.Name,user.UserName),
            new Claim(ClaimTypes.NameIdentifier,user.Id),
            new Claim("Fullname",user.Fullname)
        };

        var roles = await _userManager.GetRolesAsync(user);
        foreach (var item in roles)
        {
         claimList.Add(new Claim("role",item));   
        }

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Audience = _configuration["JWT:Audience"],
            Issuer = _configuration["JWT:Issuer"],
            Subject = new ClaimsIdentity(claimList),
            Expires = DateTime.UtcNow.AddMinutes(4),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        
        return Ok(new{token = tokenHandler.WriteToken(token)});
    }
 }


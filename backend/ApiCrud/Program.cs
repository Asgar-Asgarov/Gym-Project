using System.Text;
using ApiCrud.Data.Configurations;
using ApiCrud.Data.DAL;
using ApiCrud.Dtos;
using ApiCrud.Models;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers()
.AddFluentValidation(c=>c.RegisterValidatorsFromAssemblyContaining<ProductCreateDtoValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(MapperConfig)); 

builder.Services.AddIdentity<AppUser,IdentityRole>(options=>{
            options.Password.RequiredLength=6;
            options.Password.RequireNonAlphanumeric=true;
            options.Password.RequireDigit=true;
            options.Password.RequireLowercase=true;
            options.Password.RequireUppercase=true;
			// options.User.RequireUniqueEmail=true;

            


            options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(20);
            options.Lockout.AllowedForNewUsers=true;
            options.Lockout.MaxFailedAccessAttempts=3;
        }

        ).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


  builder.Services.AddAuthentication(x =>
	{
		x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
		x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	}).AddJwtBearer(o =>
	{
		var Key = Encoding.UTF8.GetBytes(config["JWT:SecretKey"]);
		o.SaveToken = true;
		o.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			ValidIssuer = config["JWT:Issuer"],
			ValidAudience = config["JWT:Audience"],
			IssuerSigningKey = new SymmetricSecurityKey(Key)
		};
	});
     


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

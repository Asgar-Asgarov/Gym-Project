using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ApiCrud.Dtos.UserDtos;

    public class RegisterDto
    {
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        
    }
    
    public class RegisterDtoDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoDtoValidator()
    {
        RuleFor(u=>u.Fullname).NotEmpty().MinimumLength(5).MaximumLength(20);
        RuleFor(u=>u.UserName).NotEmpty().MinimumLength(5).MaximumLength(20);
        RuleFor(u=>u.Password).NotEmpty().MinimumLength(5).MaximumLength(15);
        RuleFor(u=>u.RePassword).NotEmpty().MinimumLength(5).MaximumLength(15);

        RuleFor(u=>u).Custom((u, context)=>{
            if (u.Password!=u.RePassword)
            {
                context.AddFailure("Password","Does not match....");
            }
        }
        );
        
    }
}

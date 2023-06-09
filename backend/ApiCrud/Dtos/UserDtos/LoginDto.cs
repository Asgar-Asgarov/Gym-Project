

using FluentValidation;

namespace ApiCrud.Dtos.UserDtos;

public class LoginDto
{
    public string UserName { get; set; }
    public string Password { get; set; }
}


public class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {

        RuleFor(u => u.UserName).NotEmpty().MinimumLength(5).MaximumLength(20);
        RuleFor(u => u.Password).NotEmpty().MinimumLength(5).MaximumLength(15);



    }

}


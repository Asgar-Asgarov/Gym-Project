using FluentValidation;
namespace ApiCrud.Dtos;

public class CategoryCreateDto
{
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public IFormFile?  Photo { get; set; }


}
public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
{
    public CategoryCreateDtoValidator()
    {
        RuleFor(c=>c.Name)
        .MaximumLength(50).WithMessage("50 den boyuk olmaz")
        .NotNull().WithMessage("Bosh qoymaq olmaz");
           RuleFor(c=>c.Desc)
        .MaximumLength(300).WithMessage("300 den boyuk olmaz")
        .NotNull().WithMessage("Bosh qoymaq olmaz");
    }
}

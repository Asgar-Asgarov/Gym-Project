namespace ApiCrud.Dtos;

public class ProductUpdateDto
{
    public string? Name { get; set; }
    public string? ImageUrl    { get; set; }
    public double Price { get; set; }
    public double DiscountPrice { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}
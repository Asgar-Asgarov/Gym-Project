namespace ApiCrud.Dtos;

public class CategoryReturnDto
{
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
    public ProductInCategoryReturnDto Product { get; set; }
}

public class ProductInCategoryReturnDto
{
  public int Id { get; set; }
  public int Name { get; set; }
}

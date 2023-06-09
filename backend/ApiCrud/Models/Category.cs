namespace ApiCrud.Models;

public class Category:BaseEntity
{
    public List<Product>? Products { get; set; }
    public bool IsDeleted { get; set; }
    public string? Name { get; set; }
    public string?  Desc { get; set; }
    public string? ImageUrl{ get; set; }
}
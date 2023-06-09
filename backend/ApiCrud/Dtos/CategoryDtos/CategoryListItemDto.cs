namespace ApiCrud.Dtos;

public class CategoryListItemDto
{
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public string? ImageUrl    { get; set; }

    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
}
namespace ApiCrud.Dtos;

public class CategoryListDto
{
public int TotalCount { get; set; }
public int CurrentPage { get; set; }
public List<CategoryListItemDto>? items { get; set; }
}
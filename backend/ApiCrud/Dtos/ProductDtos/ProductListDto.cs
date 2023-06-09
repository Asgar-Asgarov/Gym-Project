namespace ApiCrud.Dtos;

public class ProductListDto
{
public int TotalCount { get; set; }
public int CurrentPage { get; set; }
public List<ProductListItemDto>? items { get; set; }
}
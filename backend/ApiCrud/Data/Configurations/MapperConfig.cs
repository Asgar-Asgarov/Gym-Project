using AutoMapper;
using ApiCrud.Models;
using ApiCrud.Dtos;

namespace ApiCrud.Data.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {   
        CreateMap<Product, ProductReturnDto>()
        .ForMember(d=>d.ImageUrl,map=>map.MapFrom(src=>"http://localhost:5261/img/"+src.ImageUrl));
        CreateMap<Category,CategoryInProductReturnDto>();
        CreateMap<Product, ProductCreateDto>().ReverseMap();
        CreateMap<Product, ProductUpdateDto>().ReverseMap();


        CreateMap<Category, CategoryReturnDto>()
        .ForMember(d=>d.ImageUrl,map=>map.MapFrom(src=>"http://localhost:5261/img/"+src.ImageUrl));
        CreateMap<Product,ProductInCategoryReturnDto>();
        CreateMap<Category, CategoryCreateDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateDto>().ReverseMap();

    }
}



using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ApiCrud.Models;
using ApiCrud.Data.DAL;
using ApiCrud.Dtos;
using AutoMapper;
using ApiCrud.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ApiCrud.Controllers;

public class ProductController : BaseController
{
    private readonly AppDbContext _appDbContext;
    private readonly IMapper _mapper;
    private readonly IWebHostEnvironment _webHostEnviroment;


    public ProductController(AppDbContext appDbContext, IMapper mapper, IWebHostEnvironment webHostEnviroment)
    {
        _appDbContext = appDbContext;
        _mapper = mapper;
        _webHostEnviroment = webHostEnviroment;
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAll(int page, string search)
    {
        var query = _appDbContext.Products
        .Include(p=>p.Category)
        .ThenInclude(c=>c.Products)    
        .Where(p => !p.IsDeleted);

        ProductListDto productListDto = new();
        productListDto.CurrentPage = page;
        productListDto.TotalCount = query.Count();
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p => p.Name.Contains(search));
        }

        productListDto.items = query.Skip((page - 1) * 2)
       .Take(2)
       .Select(p => new ProductListItemDto
       {
           Name = p.Name,
           ImageUrl = "http://localhost:5261/img/" + p.ImageUrl,
           Price = p.Price,
           DiscountPrice = p.DiscountPrice,
           CreatedTime = p.CreatedTime,
           UpdatedTime = p.UpdatedTime
       }).ToList();

        return StatusCode(200, productListDto);
    }


    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        var product = _appDbContext.Products
        .Include(p=>p.Category)
        .Where(p => !p.IsDeleted)
        .FirstOrDefault(p => p.Id == id);
        if (product == null) return StatusCode(StatusCodes.Status404NotFound);

        ProductReturnDto productReturnDto = _mapper.Map<ProductReturnDto>(product);
        
        return StatusCode(200, productReturnDto);
    }

    [HttpPost]
    public IActionResult AddProduct(ProductCreateDto productCreateDto)
    {
        // if (productCreateDto.Photo == null) return StatusCode(StatusCodes.Status409Conflict);
        // if (!productCreateDto.Photo.isImage()) return BadRequest("photo type deyil");
        // if (!productCreateDto.Photo.CheckImageSize(10)) return BadRequest("size duzgun deyil");
        var category=_appDbContext.Categories
        .Where(c=>!c.IsDeleted)
        .FirstOrDefault(c=>c.Id==productCreateDto.CategoryId);
        if(category==null)return StatusCode(StatusCodes.Status404NotFound);

        Product newProduct = new();

        this._mapper.Map(productCreateDto, newProduct);
        // newProduct.ImageUrl = productCreateDto.Photo.SaveImage(_webHostEnviroment, "img", productCreateDto.Photo.FileName);

        _appDbContext.Products.Add(newProduct);
        _appDbContext.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = _appDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null) return StatusCode(StatusCodes.Status404NotFound);
        _appDbContext.Products.Remove(product);
        _appDbContext.SaveChanges();
        return StatusCode(StatusCodes.Status204NoContent);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
    {
        var existProduct = _appDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (existProduct == null) return NotFound();

        this._mapper.Map(productUpdateDto, existProduct);

        _appDbContext.SaveChanges();
        return StatusCode(StatusCodes.Status204NoContent);

    }

    [HttpPatch]
    public IActionResult ChangeStatus(int id, bool IsActive)
    {
        var existProduct = _appDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (existProduct == null) return StatusCode(StatusCodes.Status404NotFound);
        existProduct.IsActive = IsActive;
        _appDbContext.SaveChanges();
        return StatusCode(StatusCodes.Status204NoContent);
    }



}
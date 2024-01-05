using AutoMapper;
using MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;
using MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;
using MyAkademiMyAkademiECommerce.Services.Catalog.Models;

namespace MyAkademiMyAkademiECommerce.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>();
            CreateMap<ResultCategoryDto, Category>();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}

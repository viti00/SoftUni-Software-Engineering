using AutoMapper;
using ProductShop.DTOs;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<UserInputDto, User>();
            CreateMap<ProductsInputDto, Product>();
            CreateMap<CategoriesInputDto, Category>();
            CreateMap<CategoriesProductsInputDto, CategoryProduct>();
        }
    }
}

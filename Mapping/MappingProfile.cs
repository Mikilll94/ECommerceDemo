using AutoMapper;
using ECommerceDemo.Controllers.Resources;
using ECommerceDemo.Models;

namespace ECommerceDemo.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Subcategory, SubcategoryResource>();
            CreateMap<Product, ProductResource>();
        }
    }
}

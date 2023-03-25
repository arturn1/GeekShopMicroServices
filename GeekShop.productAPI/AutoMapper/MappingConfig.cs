using AutoMapper;
using GeekShop.ProductAPI.Data.ValueObjects;
using GeekShop.ProductAPI.Models;

namespace GeekShopping.ProductAPI.Config
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
                CreateMap<ProductVO, ProductEntity>().ReverseMap();
        }
    }
}

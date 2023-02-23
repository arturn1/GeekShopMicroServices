using AutoMapper;
using GeekShop.API.Data.ValueObjects;
using GeekShop.API.Models;

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

using AutoMapper;
using GeekShop.ProductAPI.Data.ValueObjects;
using GeekShop.ProductAPI.Models;

namespace GeekShop.ProductAPI.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
                CreateMap<ProductVO, ProductEntity>().ReverseMap();
        }
    }
}

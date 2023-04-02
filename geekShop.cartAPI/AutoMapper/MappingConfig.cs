using AutoMapper;
using GeekShop.CartAPI.Data.ValueObjects;
using GeekShop.CartAPI.Model;

namespace GeekShop.CartAPI.AutoMapper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>().ReverseMap();
                config.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
                config.CreateMap<CartVO, Cart>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}

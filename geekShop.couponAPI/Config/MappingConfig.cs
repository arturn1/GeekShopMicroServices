using AutoMapper;
using GeekShop.CouponAPI.Data.ValueObjects;
using GeekShop.CouponAPI.Model;

namespace GeekShop.CouponAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<CouponVO, Coupon>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}

using GeekShop.CouponAPI.Data.ValueObjects;
using System.Threading.Tasks;

namespace GeekShop.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string couponCode); 
    }
}

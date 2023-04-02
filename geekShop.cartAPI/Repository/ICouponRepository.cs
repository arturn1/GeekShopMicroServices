using GeekShop.CartAPI.Data.ValueObjects;
using System.Threading.Tasks;

namespace GeekShop.CartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO?> GetCoupon(string couponCode, string token); 
    }
}

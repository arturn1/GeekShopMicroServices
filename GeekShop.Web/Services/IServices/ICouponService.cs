using GeekShop.Web.Models;
using System.Threading.Tasks;

namespace GeekShop.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetCoupon(string code, string token);
     }
}

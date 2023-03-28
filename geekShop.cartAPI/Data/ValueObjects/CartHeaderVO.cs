using GeekShop.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShop.CartAPI.Data.ValueObjects
{
    public class CartHeaderVO
    {
        public Guid? Id { get; set; }
        public string? UserId { get; set; }
        public string? CouponCode { get; set; }
    }
}

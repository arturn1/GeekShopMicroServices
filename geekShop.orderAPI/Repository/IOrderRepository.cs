using GeekShop.OrderAPI.Model;
using System.Threading.Tasks;

namespace GeekShop.CartAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader header);
        Task UpdateOrderPaymentStatus(Guid orderHeaderId, bool paid);
    }
}

using GeekShop.MessageBus;

namespace GeekShop.OrderAPI.Messages
{
    public class PaymentVO : BaseMessage
    {
        public Guid OrderId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryMonthYear { get; set; }
        public decimal PurchaseAmount { get; set; }
        public string Email { get; set; }
    }
}

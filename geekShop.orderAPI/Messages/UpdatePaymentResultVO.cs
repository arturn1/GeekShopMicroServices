namespace GeekShop.OrderAPI.Messages
{
    public class UpdatePaymentResultVO
    {
        public Guid OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}

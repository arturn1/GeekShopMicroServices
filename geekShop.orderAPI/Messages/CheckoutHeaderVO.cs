﻿using GeekShop.MessageBus;
using GeekShop.OrderAPI.Messages;
using System;
using System.Collections.Generic;

namespace GeekShop.OrderAPI.Messages
{
    public class CheckoutHeaderVO : BaseMessage
    {
        public Guid? UserId { get; set; }
        public string? CouponCode { get; set; }
        public decimal? PurchaseAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? CardNumber { get; set; }
        public string? CVV { get; set; }
        public string? ExpiryMothYear { get; set; }

        public string? CartTotalItens { get; set; }
        public IEnumerable<CartDetailVO>? CartDetails { get; set; }
    }
}
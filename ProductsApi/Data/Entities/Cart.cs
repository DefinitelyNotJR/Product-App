using System;
using System.Collections.Generic;
using ProductsApi.Types;

namespace ProductsApi.Data.Entities
{
    public class Cart : BaseEntity
    {
        public string SessionId { get; set; }

        public ShoppingCartStatus Status { get; set; }

        private List<CartItem> _cartItems = new List<CartItem>();
        public List<CartItem> CartItems { get { return _cartItems ?? new List<CartItem>(); } set { _cartItems = value; } }

    }
}
using System;
using ProductsApi.Types;

namespace ProductsApi.Data.Entities
{
    public class CartItem : BaseEntity
    {
        public long ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

    }
}
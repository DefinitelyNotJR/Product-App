using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsApi.Data.Entities;
using ProductsApi.Data.Models;
using ProductsApi.Services.DbService;
using ProductsApi.Types;

namespace ProductsApi.Services.DbService
{
    public class DbCartService : IDbService<Cart>
    {
        public async Task<Cart> AddOneAsync(Cart item)
        {
            Cart cart;
            using (var db = new ProductsContext())
            {
                cart = item;
                db.Add(cart);

                await db.SaveChangesAsync();

            }
            return cart;
        }

        public async Task<Cart> ClearAll(string sessionId)
        {
            Cart cart;
            using (var db = new ProductsContext())
            {
                var cartToClear = db.Carts.OrderBy(c => c.SessionId == sessionId).FirstOrDefault();

                if (cartToClear != null)
                {
                    cartToClear.CartItems.Clear();
                }
                cart = cartToClear;
            }
            return cart;
        }

        public async Task<Cart> Get(string id)
        {
            Cart cart;
            using (var db = new ProductsContext())
            {
                cart = db.Carts.Where(c => c.SessionId == id).FirstOrDefault();
                if (cart == null)
                {
                    var newCart = new Cart
                    {
                        SessionId = id,
                        Status = ShoppingCartStatus.Current,
                        CartItems = new List<CartItem>()
                    };
                    newCart.CartItems.Add(new CartItem
                    {
                        ProductId = 1,
                        ProductName = "Postman",
                        Quantity = 2
                    });
                    newCart.CartItems.Add(new CartItem
                    {
                        ProductId = 2,
                        ProductName = "Filled cookies",
                        Quantity = 3
                    });
                    cart = await AddOneAsync(newCart);
                }
                else
                {
                    cart.CartItems.Add(new CartItem
                    {
                        ProductId = 1,
                        ProductName = "Postman",
                        Quantity = 2
                    });
                    cart.CartItems.Add(new CartItem
                    {
                        ProductId = 2,
                        ProductName = "Filled cookies",
                        Quantity = 3
                    });
                }
                return cart;
            }
        }

        public async Task<Cart[]> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cart> Update(Cart item)
        {
            Cart cart;
            using (var db = new ProductsContext())
            {
                cart = db.Carts.OrderBy(c => c.SessionId == item.SessionId).FirstOrDefault();
                cart.CartItems.Clear();
                cart.CartItems.AddRange(item.CartItems);
                db.SaveChanges();

                return cart;
            }
        }
    }
}
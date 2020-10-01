using System;
using System.Linq;
using System.Threading.Tasks;
using ProductsApi.Data.Entities;
using ProductsApi.Data.Models;
using ProductsApi.Services.DbService;

namespace ProductsApi.Services.DbService
{
    public class DbProductService : IDbService<Product>
    {
        public async Task<Product> AddOneAsync(Product item)
        {
            Product product;
            using (var db = new ProductsContext())
            {
                product = item;
                db.Add(product);
                await db.SaveChangesAsync();

            }
            return product;
        }

        public Task<Product> ClearAll(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> Get(string id)
        {
            using (var db = new ProductsContext())
            {
                var product = db.Products.Where(c => c.Id == (long)Convert.ToInt64(id)).FirstOrDefault();

                return Task.Run(() =>
                {
                    return product;
                });
            }
        }

        public Task<Product[]> GetAll()
        {

            using (var db = new ProductsContext())
            {
                var products = db.Products.ToArray();

                return Task.Run(() =>
                {
                    return products;
                });
            }

        }

        public Task<Product> Update(Product item)
        {
            throw new System.NotImplementedException();
        }
    }
}
namespace SMS.Services
{
    using SMS.Data;
    using SMS.Data.Models;
    using SMS.Models.Products;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductsService : IProductsService
    {
        private readonly SMSDbContext db;

        public ProductsService(SMSDbContext db)
        {
            this.db = db;
        }

        public void AddToCart(string productId, string cartId)
        {
            var product = this.db.Products.FirstOrDefault(x => x.Id == productId);
            if (product != null)
            {
                product.CartId = cartId;
                this.db.SaveChanges();
            }            
        }

        public void Create(CreateProductInputModel input)
        {
            var product = new Product
            {
                Name = input.Name,
                Price = decimal.Parse(input.Price),
            };

            this.db.Products.Add(product);
            this.db.SaveChanges();
        }

        public void DeleteProducts(string cartId)
        {
            this.db.Products.RemoveRange(this.db.Products.Where(x => x.CartId == cartId));
            this.db.SaveChanges();
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return this.db.Products.Select(x => new ProductViewModel
            {
                ProductId = x.Id,
                Name = x.Name,
                Price = x.Price.ToString("F2"),
            }).ToList();
        }

        public IEnumerable<ProductViewModel> GetByCartId(string cartId)
        {
            return this.db.Products.Where(p => p.CartId == cartId)
                .Select(p => new ProductViewModel
                {
                    Name = p.Name,
                    Price = p.Price.ToString("F2")
                }).ToList();
        }
    }
}

namespace SMS.Services
{
    using SMS.Models.Products;
    using System.Collections.Generic;

    public interface IProductsService
    {
        void Create(CreateProductInputModel input);

        void AddToCart(string productId, string cartId);

        void DeleteProducts(string cartId);

        IEnumerable<ProductViewModel> GetAll();     
        
        IEnumerable<ProductViewModel> GetByCartId(string cartId);        
    }
}

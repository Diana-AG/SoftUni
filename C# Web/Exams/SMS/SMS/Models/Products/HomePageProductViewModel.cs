namespace SMS.Models.Products
{
    using System.Collections.Generic;

    public class HomePageProductViewModel
    {
        public string Username { get; init; }

        public IEnumerable<ProductViewModel> Products { get; init; }
    }
}

namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Models.Products;
    using SMS.Services;
    using System.Linq;

    public class ProductsController : Controller
    {
        private readonly IValidator validator;
        private readonly IProductsService productsService;

        public ProductsController(
            IValidator validator,
            IProductsService productsService)
        {
            this.validator = validator;
            this.productsService = productsService;
        }

        [Authorize]
        public HttpResponse Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public HttpResponse Create(CreateProductInputModel model)
        {
            var modelErrors = this.validator.ValidateProduct(model);
            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            this.productsService.Create(model);
            return Redirect("/");
        }
    }
}

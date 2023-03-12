namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Services;

    public class CartsController : Controller
    {
        private readonly IUsersService usersService;
        private readonly IProductsService productsService;

        public CartsController(
            IUsersService usersService,
            IProductsService productsService)
        {
            this.usersService = usersService;
            this.productsService = productsService;
        }

        [Authorize]
        public HttpResponse Details()
        {
            var cartId = this.usersService.GetUserCartId(this.User.Id);
            var viewModel = this.productsService.GetByCartId(cartId);
            return this.View(viewModel);
        }

        [Authorize]
        public HttpResponse Buy()
        {
            var cartId = this.usersService.GetUserCartId(this.User.Id);
            this.productsService.DeleteProducts(cartId);
            return this.Redirect("/");
        }

        [Authorize]
        public HttpResponse AddProduct(string productId)
        {
            var cartId = this.usersService.GetUserCartId(this.User.Id); 
            this.productsService.AddToCart(productId, cartId);
            return this.Redirect("Details");
        }
    }
}

namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Models.Products;
    using SMS.Services;

    public class HomeController : Controller
    {
        private readonly IUsersService usersService;
        private readonly IProductsService productsService;

        public HomeController(
            IUsersService usersService,
            IProductsService productsService)
        {
            this.usersService = usersService;
            this.productsService = productsService;
        }

        public HttpResponse Index()
        {
            if (this.User.IsAuthenticated)
            {                
                var viewModel = new HomePageProductViewModel
                {
                    Username = this.usersService.GetUsernameById(this.User.Id),
                    Products = this.productsService.GetAll(),
                };

                return this.View("/Home/IndexLoggedIn", viewModel);
            }

            return this.View();
        }
    }
}
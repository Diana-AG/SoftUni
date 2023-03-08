namespace CarShop.Controllers
{
    using CarShop.Services;
    using CarShop.ViewModels.Cars;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CarsController : Controller
    {
        private readonly IValidator validator;
        private readonly ICarsService carsService;
        private readonly IUsersService usersService;

        public CarsController(
            IValidator validator,
            ICarsService carsService,
            IUsersService usersService)
        {
            this.validator = validator;
            this.carsService = carsService;
            this.usersService = usersService;
        }

        [Authorize]
        public HttpResponse All()
        {
            var viewModel = this.carsService.GetByUserRole(this.usersService.IsMechanic(this.User.Id), this.User.Id);
            return View(viewModel);
        }

        [Authorize]
        public HttpResponse Add()
        {
            if (this.usersService.IsMechanic(this.User.Id))
            {
                return Error("Mechanics cannot add cars.");
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public HttpResponse Add(AddCarFormModel model)
        {
            var modelErrors = this.validator.ValidateCar(model);
            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            this.carsService.AddCar(model, this.User.Id);
            return Redirect("/Cars/All");
        }
    }
}
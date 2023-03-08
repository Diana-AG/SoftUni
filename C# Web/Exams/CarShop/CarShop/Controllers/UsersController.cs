namespace CarShop.Controllers
{
    using CarShop.Services;
    using CarShop.ViewModels.Users;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly IUsersService usersService;

        public UsersController(
            IValidator validator,
            IUsersService usersService)
        {
            this.validator = validator;
            this.usersService = usersService;
        }

        public HttpResponse Register()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelErrors = this.validator.ValidateUser(model);

            if (!this.usersService.IsUsernameAvailable(model.Username))
            {
                modelErrors.Add($"User with '{model.Username}' username already exists.");
            }

            if (!this.usersService.IsEmailAvailable(model.Email))
            {
                modelErrors.Add($"User with '{model.Email}' e-mail already exists.");
            }

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            this.usersService.CreateUser(model);
            return this.Redirect("/Users/Login");
        }


        public HttpResponse Login()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(LoginUserFormModel model)
        {
            var userId = this.usersService.GetUserId(model.Username, model.Password);
            if (userId == null)
            {
                return Error("Username and password combination is not valid.");
            }

            this.SignIn(userId);
            return this.Redirect("/Cars/All");
        }

        [Authorize]
        public HttpResponse Logout()
        {
            this.SignOut();
            return Redirect("/");
        }
    }
}

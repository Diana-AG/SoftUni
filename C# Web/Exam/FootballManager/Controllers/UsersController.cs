namespace FootballManager.Controllers
{
    using FootballManager.Services;
    using FootballManager.ViewModels.Users;
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
            if (this.User.IsAuthenticated)
            {
                return this.Redirect("/");
            }

            return this.View();
        }
        
        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return this.Redirect("/");
            }

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
                return this.Error(modelErrors);
            }

            this.usersService.CreateUser(model.Username, model.Email, model.Password);
            return Redirect("/Users/Login");
        }

        public HttpResponse Login()
        {
            if (this.User.IsAuthenticated)
            {
                return this.Redirect("/");
            }

            return this.View();
            // return this.Login(new LoginUserFormModel { Username = "DianaG", Password = "DianaG"});
        }

        [HttpPost]
        public HttpResponse Login(LoginUserFormModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return this.Redirect("/");
            }

            var userId = this.usersService.GetUserId(model.Username, model.Password);
            if (userId == null)
            {
                return this.Error("Invalid username or password.");
            }

            this.SignIn(userId);
            return this.Redirect("/Players/All");
        }

        [Authorize]
        public HttpResponse Logout()
        {
            if (this.User.IsAuthenticated)
            {
                return this.Error("Only logged-in users can logout.");
            }

            this.SignOut();
            return this.Redirect("/");
        }
    }
}

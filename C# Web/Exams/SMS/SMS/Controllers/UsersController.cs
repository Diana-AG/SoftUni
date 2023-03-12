namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Models.Users;
    using SMS.Services;
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
        public HttpResponse Register(RegisterUserInputModel input)
        {
            var modelErrors = this.validator.ValidateUser(input);

            if (!this.usersService.IsUsernameAvailable(input.Username))
            {
                return this.Error("Username already taken.");
            }

            if (!this.usersService.IsEmailAvailable(input.Email))
            {
                return this.Error("Email already taken.");
            }

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var user = this.usersService.CreateUser(input);
            return Redirect("/Users/Login");
        }

        public HttpResponse Login()
        {            
            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(LoginUserInputModel model)
        {
            var userId = this.usersService.GetUserId(model.Username, model.Password);
            if (userId == null)
            {
                return this.Error("Invalid username or password");
            }

            this.SignIn(userId);
            return Redirect("/");
        }

        [Authorize]
        public HttpResponse Logout()
        {
            this.SignOut();
            return Redirect("/");
        }
    }
}

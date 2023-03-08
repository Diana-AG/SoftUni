namespace BattleCards.Controllers
{
    using BattleCards.Services;
    using BattleCards.ViewModels.Users;
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        // GET /users/login
        public HttpResponse Login()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(string username, string password)
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            var userId = this.usersService.GetUserId(username, password);
            if (userId == null)
            {
                return this.Error("Invalid username or password");
            }

            this.SignIn(userId);
            return this.Redirect("/Cards/All");
        }

        // GET /users/register
        public HttpResponse Register()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputModel model)
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }
                        
            if (model.Username == null || model.Username.Length < 5 || model.Username.Length > 20)
            {
                return this.Error("Invalid username. The username should be between 5 and 20 characters.");
            }

            if (!Regex.IsMatch(model.Username, @"^[a-zA-Z0-9\.]+$"))
            {
                return this.Error("Invalid username. Only alphanumeric characters are allowed.");
            }

            if (string.IsNullOrWhiteSpace(model.Email) || !new EmailAddressAttribute().IsValid(model.Email))
            {
                return this.Error("Invalid email.");
            }

            if (model.Password == null || model.Password.Length < 6 || model.Password.Length > 20)
            {
                return this.Error("Invalid password. The password should be between 6 and 20 characters.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                return this.Error("Passwords should be the same.");
            }

            if (!this.usersService.IsUsernameAvailable(model.Username))
            {
                return this.Error("Username already taken.");
            }

            if (!this.usersService.IsEmailAvailable(model.Email))
            {
                return this.Error("Email already taken.");
            }

            this.usersService.CreateUser(model.Username, model.Email, model.Password);
            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Error("Only logged-in users can logout.");
            }

            this.SignOut();
            return this.Redirect("/");
        }
    }
}

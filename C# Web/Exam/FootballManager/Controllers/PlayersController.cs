namespace FootballManager.Controllers
{
    using FootballManager.Services;
    using FootballManager.ViewModels.Players;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class PlayersController : Controller
    {
        private readonly IValidator validator;
        private readonly IPlayerService playerService;

        public PlayersController(
            IValidator validator,
            IPlayerService playerService)
        {
            this.validator = validator;
            this.playerService = playerService;
        }

        [Authorize]
        public HttpResponse All()
        {
            var viewModel = this.playerService.GetAll();
            return this.View(viewModel);
        }

        [Authorize]
        public HttpResponse Collection()
        {
            var viewModel = this.playerService.GetByUserId(this.User.Id);
            return this.View(viewModel);
        }

        [Authorize]
        public HttpResponse Add()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public HttpResponse Add(AddPlayerInputModel model)
        {
            var modelErrors = this.validator.ValidatePlayer(model);
            if (modelErrors.Any())
            {
                return this.Error(modelErrors);
            }

            var userId = this.User.Id;
            var playerId = this.playerService.AddPlayer(model);
            this.playerService.AddPlayerToUserCollection(userId, playerId);            
            return this.Redirect("/Players/All");
        }

        [Authorize]
        public HttpResponse AddToCollection(int playerId)
        {
            var userId = this.User.Id;
            this.playerService.AddPlayerToUserCollection(userId, playerId);
            return this.Redirect("/Players/All");
        }

        [Authorize]
        public HttpResponse RemoveFromCollection(int playerId)
        {
            var userId = this.User.Id;
            this.playerService.RemovePlayerFromUserCollection(userId, playerId);
            return this.Redirect("/Players/Collection");
        }
    }
}
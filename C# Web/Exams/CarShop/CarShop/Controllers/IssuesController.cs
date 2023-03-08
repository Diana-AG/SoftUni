namespace CarShop.Controllers
{
    using CarShop.Services;
    using CarShop.ViewModels.Issues;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class IssuesController : Controller
    {
        private readonly IValidator validator;
        private readonly IUsersService usersService;
        private readonly IIssuesService issuesService;

        public IssuesController(
            IValidator validator,
            IUsersService usersService,
            IIssuesService issuesService)
        {
            this.validator = validator;
            this.usersService = usersService;
            this.issuesService = issuesService;
        }

        [Authorize]
        public HttpResponse CarIssues(string carId)
        {
            if (!this.usersService.UserCanAccessCar(this.User.Id, carId))
            {
                return Unauthorized();
            }

            var issues = this.issuesService.GetAllByCarId(carId, this.User.Id);
            if (issues == null)
            {
                return NotFound();
            }

            return this.View(issues);
        }

        [Authorize]
        public HttpResponse Add(string carId)
        {
            return View(new AddIssueViewModel
            { 
                CarId = carId
            });
        }

        [HttpPost]
        [Authorize]
        public HttpResponse Add(AddIssueFormModel model)
        {
            if (!this.usersService.UserCanAccessCar(this.User.Id, model.CarId))
            {
                return Unauthorized();
            }

            var modelErrors = this.validator.ValidateIssue(model);
            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            this.issuesService.AddIssue(model);
            return Redirect($"/Issues/CarIssues?carId={model.CarId}");
        }

        [Authorize]
        public HttpResponse Fix(string issueId, string carId)
        {
            var userIsMechanic = this.usersService.IsMechanic(this.User.Id);
            if (!userIsMechanic)
            {
                return Unauthorized();
            }

            this.issuesService.FixIssue(issueId, carId);
            return Redirect($"/Issues/CarIssues?carId={carId}");
        }

        [Authorize]
        public HttpResponse Delete(string issueId, string carId)
        {
            if (!this.usersService.UserCanAccessCar(this.User.Id, carId))
            {
                return Unauthorized();
            }

            this.issuesService.Delete(issueId, carId);
            return Redirect($"/Issues/CarIssues?carId={carId}");
        }
    }
}

namespace CarShop.Services
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.ViewModels.Issues;
    using System.Linq;

    public class IssuesService : IIssuesService
    {
        private readonly ApplicationDbContext db;
        private readonly IUsersService usersService;

        public IssuesService(
            ApplicationDbContext db,
            IUsersService usersService)
        {
            this.db = db;
            this.usersService = usersService;
        }
        public void AddIssue(AddIssueFormModel model)
        {
            var issue = new Issue
            {
                CarId = model.CarId,
                Description = model.Description,
            };

            this.db.Issues.Add(issue);
            this.db.SaveChanges();
        }

        public void Delete(string issueId, string carId)
        {
            var issue = this.db.Issues.Find(issueId);
            if (issue == null || issue.CarId != carId)
            {
                return;
            }
            this.db.Issues.Remove(issue);
            this.db.SaveChanges();
        }

        public void FixIssue(string issueId, string carId)
        {
            var issue = this.db.Issues.Find(issueId);
            if (issue == null || issue.CarId != carId)
            {
                return;
            }
            issue.IsFixed = true;
            this.db.SaveChanges();
        }

        public CarIssuesViewModel GetAllByCarId(string carId, string userId)
        {
            return this.db
                .Cars
                .Where(c => c.Id == carId)
                .Select(c => new CarIssuesViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Year = c.Year,
                    UserIsMechanic = this.usersService.IsMechanic(userId),
                    Issues = c.Issues
                    .Select(i => new IssueListingViewModel
                    {
                        Id = i.Id,
                        Description = i.Description,
                        IsFixed = i.IsFixed,
                        IsFixedInformation = i.IsFixed ? "Yes" : "Not Yet"
                    })
                }).FirstOrDefault();
        }
    }
}

namespace CarShop.Services
{
    using CarShop.ViewModels.Issues;

    public interface IIssuesService
    {
        CarIssuesViewModel GetAllByCarId(string carId, string userId);
        void AddIssue(AddIssueFormModel model);

        void FixIssue(string issueId, string carId);

        void Delete(string issueId, string carId);
    }
}

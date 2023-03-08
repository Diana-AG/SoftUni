namespace CarShop.Services
{
    using CarShop.ViewModels.Users;

    public interface IUsersService
    {
        string CreateUser(RegisterUserFormModel model);

        bool IsEmailAvailable(string email);

        string GetUserId(string username, string password);

        bool IsUsernameAvailable(string username);

        bool IsMechanic(string userId);

        bool OwnsCar(string userId, string carId);

        bool UserCanAccessCar(string userId, string carId);
    }
}

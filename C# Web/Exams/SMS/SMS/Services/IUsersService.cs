namespace SMS.Services
{
    using SMS.Data.Models;
    using SMS.Models.Users;

    public interface IUsersService
    {
        string CreateUser(RegisterUserInputModel model);

        bool IsEmailAvailable(string email);

        bool IsUsernameAvailable(string username);

        string GetUserId(string username, string password);

        string GetUsernameById(string userId);

        string GetUserCartId(string userId);

        User GetUserById(string userId);
    }
}

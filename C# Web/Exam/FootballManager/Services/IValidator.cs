namespace FootballManager.Services
{
    using FootballManager.ViewModels.Players;
    using FootballManager.ViewModels.Users;
    using System.Collections.Generic;

    public interface IValidator
    {
        ICollection<string> ValidateUser(RegisterUserFormModel user);
        ICollection<string> ValidatePlayer(AddPlayerInputModel player);
    }
}

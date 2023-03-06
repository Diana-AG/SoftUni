namespace FootballManager.Services
{
    using FootballManager.ViewModels.Players;
    using System.Collections.Generic;

    public interface IPlayerService
    {
        int AddPlayer(AddPlayerInputModel input);

        IEnumerable<PlayerViewModel> GetAll();

        IEnumerable<PlayerViewModel> GetByUserId(string userId);

        void AddPlayerToUserCollection(string userId, int playerId);

        void RemovePlayerFromUserCollection(string userId, int playerId);
    }
}

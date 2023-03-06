namespace FootballManager.Services
{
    using FootballManager.Data;
    using FootballManager.Data.Models;
    using FootballManager.ViewModels.Players;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayerService : IPlayerService
    {
        private readonly FootballManagerDbContext db;

        public PlayerService(FootballManagerDbContext db)
        {
            this.db = db;
        }

        public int AddPlayer(AddPlayerInputModel input)
        {
            var player = new Player
            {
                FullName = input.FullName,
                ImageUrl = input.ImageURL,
                Position = input.Position,
                Speed = byte.Parse(input.Speed),
                Endurance = byte.Parse(input.Endurance),
                Description = input.Description,
            };

            this.db.Players.Add(player);
            this.db.SaveChanges();
            return player.Id;
        }

        public void AddPlayerToUserCollection(string userId, int playerId)
        {
            if (this.db.UserPlayers.Any(x => x.UserId == userId && x.PlayerId == playerId))
            {
                return;
            }

            this.db.UserPlayers.Add(new UserPlayer
            {
                UserId = userId,
                PlayerId = playerId,
            });
            this.db.SaveChanges();
        }

        public IEnumerable<PlayerViewModel> GetAll()
        {
            return this.db.Players
                .Select(x => new PlayerViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Description = x.Description,
                    Endurance = x.Endurance,
                    Position = x.Position,
                    ImageUrl = x.ImageUrl,
                    Speed = x.Speed,

                }).ToList();
        }

        public IEnumerable<PlayerViewModel> GetByUserId(string userId)
        {
            return this.db.UserPlayers.Where(x => x.UserId == userId)
                .Select(x => new PlayerViewModel
                {
                    Id = x.Player.Id,
                    FullName = x.Player.FullName,
                    Description = x.Player.Description,
                    Endurance = x.Player.Endurance,
                    Position = x.Player.Position,
                    ImageUrl = x.Player.ImageUrl,
                    Speed = x.Player.Speed,

                }).ToList();
        }

        public void RemovePlayerFromUserCollection(string userId, int playerId)
        {
            var userPlayer = this.db.UserPlayers.FirstOrDefault(x => x.UserId == userId && x.PlayerId == playerId);

            if (userPlayer == null)
            {
                return;
            }

            this.db.UserPlayers.Remove(userPlayer);
            this.db.SaveChanges();
        }
    }
}

namespace FootballManager.Data.Models
{
    public class UserPlayer
    {
        public string UserId { get; init; }
        public User User { get; set; }
        public int PlayerId { get; init; }
        public Player Player { get; set; }
    }
}

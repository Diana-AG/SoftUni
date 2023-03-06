namespace FootballManager.Services
{
    using FootballManager.Data;
    using FootballManager.Data.Models;
    using System.Linq;

    public class UsersService : IUsersService
    {
        private readonly FootballManagerDbContext db;
        private readonly IPasswordHasher passwordHasher;

        public UsersService(
            FootballManagerDbContext db,
            IPasswordHasher passwordHasher)
        {
            this.db = db;
            this.passwordHasher = passwordHasher;
        }

        public string CreateUser(string username, string email, string password)
        {
            var user = new User
            {
                Username = username,
                Password = this.passwordHasher.HashPassword(password),
                Email = email,
            };

            this.db.Users.Add(user);
            this.db.SaveChanges();
            return user.Id;
        }

        public string GetUserId(string username, string password)
        {
            var passwordHash = this.passwordHasher.HashPassword(password);
            return this.db.Users.FirstOrDefault(x => x.Username == username && x.Password == passwordHash)?.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return !this.db.Users.Any(x => x.Email == email);
        }

        public bool IsUsernameAvailable(string username)
        {
            return !this.db.Users.Any(x => x.Username == username);
        }
    }
}

namespace SMS.Services
{
    using Microsoft.EntityFrameworkCore;
    using SMS.Data;
    using SMS.Data.Models;
    using SMS.Models.Users;
    using System.Linq;

    public class UsersService : IUsersService
    {
        private readonly SMSDbContext db;
        private readonly IPasswordHasher passwordHasher;

        public UsersService(
            SMSDbContext db,
            IPasswordHasher passwordHasher)
        {
            this.db = db;
            this.passwordHasher = passwordHasher;
        }

        public string CreateUser(RegisterUserInputModel model)
        {
            var user = new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = this.passwordHasher.HashPassword(model.Password),
                Cart = new Cart(),
            };

            db.Users.Add(user);
            db.SaveChanges();
            return user?.Id;
        }

        public User GetUserById(string userId)
        {
            return this.db.Users.Where(x => x.Id == userId)
                .Include(x => x.Cart)
                .ThenInclude(x => x.Products)
                .FirstOrDefault();
        }

        public string GetUserCartId(string userId)
        {
            return this.db.Users.FirstOrDefault(x => x.Id == userId)?.CartId;
        }

        public string GetUserId(string username, string password)
        {
            var passwordHash = passwordHasher.HashPassword(password);
            var user = this.db.Users.FirstOrDefault(x => x.Username == username && x.Password == passwordHash);

            return user?.Id;
        }

        public string GetUsernameById(string userId)
        {
            return this.db.Users.FirstOrDefault(x => x.Id == userId)?.Username;
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

namespace CarShop.Services
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.ViewModels.Users;
    using System.Linq;

    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;
        private readonly IPasswordHasher passwordHasher;

        public UsersService(
            ApplicationDbContext db,
            IPasswordHasher passwordHasher)
        {
            this.db = db;
            this.passwordHasher = passwordHasher;
        }

        public string CreateUser(RegisterUserFormModel model)
        {
            var user = new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = this.passwordHasher.HashPassword(model.Password),
                IsMechanic = model.UserType == Constants.UserTypeMechanic
            };

            db.Users.Add(user);
            db.SaveChanges();
            return user?.Id;
        }

        public string GetUserId(string username, string password)
        {
            var user = this.db.Users.FirstOrDefault(x => x.Username == username);
            if (user?.Password != this.passwordHasher.HashPassword(password))
            {
                return null;
            }

            return user.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return !this.db.Users.Any(x => x.Email == email);
        }

        public bool IsMechanic(string userId)
        {
            return this.db
                .Users
                .Any(u => u.Id == userId && u.IsMechanic);
        }

        public bool IsUsernameAvailable(string username)
        {
            return !this.db.Users.Any(x => x.Username == username);
        }

        public bool OwnsCar(string userId, string carId) 
        { 
            return this.db
                .Cars
                .Any(c => c.Id == carId && c.OwnerId == userId);
        }

        public bool UserCanAccessCar(string userId, string carId)
        {
            return this.IsMechanic(userId) ||
                this.OwnsCar(userId, carId);
        }
    }
}
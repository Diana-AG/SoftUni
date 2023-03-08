namespace CarShop.Services
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.ViewModels.Cars;
    using System.Collections.Generic;
    using System.Linq;

    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext db;

        public CarsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddCar(AddCarFormModel model, string userId)
        {
            var car = new Car
            {
                Model = model.Model,
                Year = model.Year,
                PlateNumber = model.PlateNumber,
                PictureUrl = model.Image,
                OwnerId = userId,
            };
            db.Cars.Add(car);
            db.SaveChanges();

        }

        public ICollection<CarListingViewModel> GetByUserRole(bool isMechanic, string userId)
        {
            var carsQuery = this.db
                .Cars
                .AsQueryable();

            carsQuery = isMechanic
                ? carsQuery
                    .Where(c => c.Issues.Any(i => !i.IsFixed))
                : carsQuery
                    .Where(c => c.OwnerId == userId);                    

            return carsQuery
                .Select(c => new CarListingViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Year = c.Year,
                    Image = c.PictureUrl,
                    PlateNumber = c.PlateNumber.Insert(2, " ").Insert(7, " "),
                    RemainingIssues = c.Issues.Count(i => !i.IsFixed),
                    FixedIssues = c.Issues.Count(i => i.IsFixed)
                }).ToList();
        }
    }
}

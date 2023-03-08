namespace CarShop.Services
{
    using CarShop.ViewModels.Cars;
    using System.Collections.Generic;

    public interface ICarsService
    {
        ICollection<CarListingViewModel> GetByUserRole(bool isMechanic, string userId);
        void AddCar(AddCarFormModel model, string userId);
    }
}

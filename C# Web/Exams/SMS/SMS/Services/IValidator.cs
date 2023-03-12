namespace SMS.Services
{
    using SMS.Models.Products;
    using SMS.Models.Users;
    using System.Collections.Generic;

    public interface IValidator
    {
        ICollection<string> ValidateUser(RegisterUserInputModel model);
        ICollection<string> ValidateProduct(CreateProductInputModel model);
    }
}

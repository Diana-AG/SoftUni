namespace SMS.Services
{
    using SMS.Models.Products;
    using SMS.Models.Users;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateProduct(CreateProductInputModel product)
        {
            var errors = new List<string>();

            if (product.Name == null || product.Name.Length < ProductNameMinLength || product.Name.Length > ProductNameMaxLength)
            {
                errors.Add($"Product Name '{product.Name}' is not valid. It must be between {ProductNameMinLength} and {ProductNameMaxLength} characters long.");
            }

            if (!decimal.TryParse(product.Price, out decimal parsedPrice))
            {
                errors.Add($"Product Price is not valid.");
            }
            else
            {
                if (parsedPrice < 0.05M || parsedPrice > 1000M)
                {
                    errors.Add($"Product Price '{product.Price}' is not valid. It must be between {ProductPriceMin} and {ProductPriceMax}.");
                }
            }

            return errors;
        }

        public ICollection<string> ValidateUser(RegisterUserInputModel user)
        {
            var errors = new List<string>();

            if (user.Username == null || user.Username.Length < UserUsernameMinLength || user.Username.Length > UserUsernameMaxLength)
            {
                errors.Add($"Username '{user.Username}' is not valid. It must be between {UserUsernameMinLength} and {UserUsernameMaxLength} characters long.");
            }

            if (user.Email == null || !Regex.IsMatch(user.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email '{user.Email}' is not a valid e-mail address.");
            }

            if (user.Password == null || user.Password.Length < UserPasswordMinLength || user.Password.Length > UserPasswordMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {UserPasswordMinLength} and {UserPasswordMaxLength} characters long.");
            }

            if (user.Password != null && user.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (user.Password != user.ConfirmPassword)
            {
                errors.Add("Password and its confirmation are different.");
            }

            return errors;
        }
    }
}

namespace CarShop.Services
{
    using CarShop.Data;
    using CarShop.ViewModels.Cars;
    using CarShop.ViewModels.Issues;
    using CarShop.ViewModels.Users;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateCar(AddCarFormModel model)
        {
            var errors = new List<string>();

            if (model.Model == null ||
                model.Model.Length < Constants.CarModelMinLength ||
                model.Model.Length > Constants.DefaultMaxLength)
            {
                errors.Add($"Model '{model.Model}' is not valid. It must be between {Constants.CarModelMinLength} and {Constants.DefaultMaxLength} characters long.");
            }

            if (model.Year < Constants.CarYearMinValue ||
                model.Year > Constants.CarYearMaxValue)
            {
                errors.Add($"Year '{model.Year}' is not valid. It must be between {Constants.CarYearMinValue} and {Constants.CarYearMaxValue}.");
            }

            if (model.Image == null || 
                !Uri.IsWellFormedUriString(model.Image, UriKind.Absolute))
            {
                errors.Add($"Image '{model.Image}' is not valid. It must be a valid URL.");
            }

            if (model.PlateNumber == null ||
                !Regex.IsMatch(model.PlateNumber, Constants.CarPlateNumberRegularExpression))
            {
                errors.Add($"Plate number '{model.PlateNumber}' is not valid. It should be in 'XX0000XX' format.");
            }

            return errors;
        }

        public ICollection<string> ValidateIssue(AddIssueFormModel model)
        {
            var errors = new List<string>();

            if (model.CarId == null)
            {
                errors.Add($"Car ID cannot be empty.");
            }

            if (model.Description.Length < Constants.IssueMinDescription)
            {
                errors.Add($"Description '{model.Description}' is not valid. It must have more than {Constants.IssueMinDescription} characters.");
            }

            return errors;
        }

        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username == null ||
                model.Username.Length < Constants.UserMinUsername ||
                model.Username.Length > Constants.DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must be between {Constants.UserMinUsername} and {Constants.DefaultMaxLength} characters long.");
            }

            if (model.Email == null || 
                !Regex.IsMatch(model.Email, Constants.UserEmailRegularExpression))
            {
                errors.Add($"Email '{model.Email}' is not a valid e-mail address.");
            }

            if (model.Password == null || 
                model.Password.Length < Constants.UserMinPassword || 
                model.Password.Length > Constants.DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {Constants.UserMinPassword} and {Constants.DefaultMaxLength} characters long.");
            }

            if (model.Password != null && 
                model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add("Password and its confirmation are different.");
            }

            if (model.UserType != Constants.UserTypeClient &&
                model.UserType != Constants.UserTypeMechanic)
            {
                errors.Add($"The user can be either a '{Constants.UserTypeClient}' or a '{Constants.UserTypeMechanic}'.");
            }

            return errors;
        }
    }
}

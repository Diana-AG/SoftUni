namespace FootballManager.Services
{
    using FootballManager.ViewModels.Players;
    using FootballManager.ViewModels.Users;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using static Data.DataConstants;

    public class Validator : IValidator
    {

        public ICollection<string> ValidatePlayer(AddPlayerInputModel player)
        {
            var errors = new List<string>();

            if (player.FullName == null || player.FullName.Length < PlayerFullNamelMinLength || player.FullName.Length > PlayerFullNameMaxLength)
            {
                errors.Add($"Full Name '{player.FullName}' is not valid. It must be between {PlayerFullNamelMinLength} and {PlayerFullNameMaxLength} characters long.");
            }

            if (player.ImageURL == null || !Uri.IsWellFormedUriString(player.ImageURL, UriKind.Absolute))
            {
                errors.Add($"ImageUrl '{player.ImageURL}' is not valid. It must be a valid URL.");
            }

            if (player.Position == null || player.Position.Length < PlayerPositionMinLength || player.Position.Length > PlayerPositionMaxLength)
            {
                errors.Add($"Position '{player.Position}' is not valid. It must be between {PlayerPositionMinLength} and {PlayerPositionMaxLength} characters long.");                
            }

            if (!int.TryParse(player.Speed, out int parsedSpeed))
            {
                errors.Add($"Speed '{player.Speed}' is not valid. It must be a number.");
            }
            else
            {
                if (parsedSpeed < PlayerSpeedMinLength || parsedSpeed > PlayerSpeedMaxLength)
                {
                    errors.Add($"Speed '{player.Speed}' is not valid. It must be between {PlayerSpeedMinLength} and {PlayerSpeedMaxLength}.");
                }
            }

            if (!int.TryParse(player.Endurance, out int parsedEndurance))
            {
                errors.Add($"Endurance '{player.Endurance}' is not valid. It must be a number.");
            }
            else
            {
                if (parsedEndurance < PlayerEnduranceMinLength || parsedEndurance > PlayerEnduranceMaxLength)
                {
                    errors.Add($"Endurance '{player.Endurance}' is not valid. It must be between {PlayerEnduranceMinLength} and {PlayerEnduranceMaxLength}.");
                }
            }

            if (player.Description == null || player.Description.Length > PlayerDescriptionMaxLength)
            {
                errors.Add($"Position '{player.Position}' is not valid. It can not be more than {PlayerDescriptionMaxLength} characters long.");
            }

            return errors;
        }

        public ICollection<string> ValidateUser(RegisterUserFormModel user)
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

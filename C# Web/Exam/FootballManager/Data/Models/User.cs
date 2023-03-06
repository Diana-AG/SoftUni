namespace FootballManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class User
    {
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(UserUsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        [MaxLength(UserEmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(UserPasswordDbMaxLength)]
        public string Password { get; set; }

        public ICollection<UserPlayer> UserPlayers { get; init; } = new HashSet<UserPlayer>();
    }
}
//•	Has an Id – a string, Primary Key
//•	Has a Username – a string with min length 5 and max length 20 (required)
//•	Has an Email – a string with min length 10 and max length 60 (required)
//•	Has a Password – a string with min length 5 and max length 20 (before hashed)  -no max length required for a hashed password in the database (required)
//•	Has UserPlayers collection
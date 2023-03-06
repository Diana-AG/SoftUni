namespace FootballManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Player
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(PlayerFullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(PlayerPositionMaxLength)]
        public string Position { get; set; }

        [Range(typeof(byte), "0", "10")]
        public byte Speed { get; set; }
        
        [Range(typeof(byte), "0", "10")]
        public byte Endurance { get; set; }

        [Required]
        [MaxLength(PlayerDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<UserPlayer> UserPlayers { get; init; } = new HashSet<UserPlayer>();
    }
}
//•	Has Id – an int, Primary Key
//•	Has FullName – a string (required); min.length: 5, max.length: 80
//•	Has ImageUrl – a string (required)
//•	Has Position – a string (required); min.length: 5, max.length: 20
//•	Has Speed – a byte (required); cannot be negative or bigger than 10
//•	Has Endurance – a byte (required); cannot be negative or bigger than 10
//•	Has a Description – a string with max length 200 (required)
//•	Has UserPlayers collection


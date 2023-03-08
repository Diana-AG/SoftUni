using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CarShop.Data.Models
{
    public class Car
    {
        [MaxLength(Constants.IdMaxLength)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(Constants.DefaultMaxLength)]
        public string Model { get; set; }

        public int Year { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(Constants.CarPlateNumberMaxLength)]
        public string PlateNumber { get; set; }

        [Required]
        [MaxLength(Constants.IdMaxLength)]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        public ICollection<Issue> Issues { get; set; } = new HashSet<Issue>();

    }
}
//•	Has an Id – a string, Primary Key
//•	Has a Model – a string with min length 5 and max length 20 (required)
//•	Has a Year – a number (required)
//•	Has a PictureUrl – string (required)
//•	Has a PlateNumber – a string – Must be a valid Plate number (2 Capital English letters, followed by 4 digits, followed by 2 Capital English letters (required)
//•	Has a OwnerId – a string (required)
//•	Has a Owner – a User object
//•	Has Issues collection – an Issue type


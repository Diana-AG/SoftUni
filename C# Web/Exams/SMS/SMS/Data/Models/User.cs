namespace SMS.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataConstants;

    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(UserUsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        [MaxLength(UserEmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(UserPasswordHashMaxLength)]
        public string Password { get; set; }

        [Required]
        [MaxLength(IdMaxLength)]
        [ForeignKey(nameof(Cart))]
        public string CartId { get; set; }

        public virtual Cart Cart { get; set; }
    }
}

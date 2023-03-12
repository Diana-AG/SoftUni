namespace SMS.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Range(typeof(decimal), "0.05", "1000")]
        public decimal Price { get; set; }


        [MaxLength(IdMaxLength)]
        public string CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }
}

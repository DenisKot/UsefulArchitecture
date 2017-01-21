namespace UsefulArchitecture.Domain.Product
{
    using System.ComponentModel.DataAnnotations;

    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(StringLengths.LongLength)]
        public string Title { get; set; }

        [Required]
        public double Coast { get; set; }
        
        [MaxLength(StringLengths.MaxLength)]
        public string Description { get; set; }
        
        public byte[] Image { get; set; }
    }
}
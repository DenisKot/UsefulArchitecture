namespace UsefulArchitecture.Domain.Order
{
    using System.ComponentModel.DataAnnotations;
    using Product;

    public class OrderProduct : DetailEntity<Order>
    {
        [Required]
        public virtual Product Product { get; set; }
        
        [Required]
        public int Count { get; set; }

        [Required]
        public double Coast { get; set; }
    }
}
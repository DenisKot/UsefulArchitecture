namespace UsefulArchitecture.Domain.Order
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using User;

    public class Order : BaseEntity
    {
        [NotMapped]
        public string Number => $"№ {this.Id}";
        
        /// <summary>
        /// Користувач
        /// </summary>
        [Required]
        public virtual User User { get; set; }

        /// <summary>
        /// Товари
        /// </summary>
        public virtual ICollection<OrderProduct> ProductOrders { get; set; }
    }
}
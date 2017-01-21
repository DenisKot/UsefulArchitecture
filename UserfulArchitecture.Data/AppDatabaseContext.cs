namespace UserfulArchitecture.Data
{
    using System.Data.Entity;
    using UsefulArchitecture.Domain.Order;
    using UsefulArchitecture.Domain.Product;
    using UsefulArchitecture.Domain.User;

    public class AppDatabaseContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public AppDatabaseContext()
            : base("AppDatabaseContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasRequired(x => x.Parent).WithMany(x => x.ProductOrders).Map(m => m.MapKey("Order_Id")).WillCascadeOnDelete(true);
        }
    }
}
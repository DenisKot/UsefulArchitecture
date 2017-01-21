namespace UserfulArchitecture.Data.Migrations.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UsefulArchitecture.Domain.Product;

    internal sealed class Configuration : DbMigrationsConfiguration<UserfulArchitecture.Data.AppDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserfulArchitecture.Data.AppDatabaseContext context)
        {
            var isEmpty = !context.Products.AsQueryable().Any();

            if (isEmpty)
            {
                for (int i = 0; i < 20; i++)
                {
                    context.Products.Add(new Product
                    {
                        Coast = i * 10,
                        Title = $"Товар {i+1}",
                        Description = $"Опис товару №{i + 1}"
                    });
                }
            }
        }
    }
}

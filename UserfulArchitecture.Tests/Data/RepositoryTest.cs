namespace UserfulArchitecture.Tests.Data
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    using UsefulArchitecture.Domain.Product;
    using UsefulArchitecture.Domain.User;
    using UserfulArchitecture.Data;
    using UserfulArchitecture.Data.Repositories;
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class RepositoryTest : BaseTest
    {
        [TestMethod]
        public void TestInsertAndDelete()
        {
            var repo = new Repository(this.context);
            var beforeCount = repo.Queryable<Product>().Count();

            var testItem = new Product {Title = "TestProduct"};
            repo.Add(testItem);
            repo.SaveChanges();

            var afterInsert = repo.Queryable<Product>().Count();
            Assert.AreEqual(beforeCount + 1, afterInsert);

            repo.Reomove(testItem);
            repo.SaveChanges();

            var afterDelete = repo.Queryable<Product>().Count();
            Assert.AreEqual(beforeCount, afterDelete);
        }

        [TestMethod]
        public void TestRepository()
        {
            using (var context = new AppDatabaseContext())
            {
                var repo = new Repository(context);
                var product = repo.FindById<User>(5);

                //var products = context.Products.Where(p => p.Coast > 100).ToList();
                var products = repo.List<Product>(p => p.Coast > 100);
            }
        }
    }
}
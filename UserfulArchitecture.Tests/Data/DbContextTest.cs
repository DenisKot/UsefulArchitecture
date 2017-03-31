namespace UserfulArchitecture.Tests.Data
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UserfulArchitecture.Data;

    [TestClass]
    public class DbContextTest
    {
        [TestMethod]
        public void TestProduncts()
        {
            using (var context = new AppDatabaseContext())
            {
                var products = context.Products.Where(p => p.Coast > 100).ToList();
                foreach (var p in products)
                {
                    System.Diagnostics.Trace.WriteLine($"{p.Title}, Coast: {p.Coast}");
                }
            }
        }
    }
}
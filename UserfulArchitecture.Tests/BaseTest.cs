namespace UserfulArchitecture.Tests
{
    using System.Data.Common;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UserfulArchitecture.Data;

    [TestClass]
    public abstract class BaseTest
    {
        protected AppDatabaseContext context;

        [TestInitialize]
        public void SetupTest()
        {
            // create a new DbConnection using Effort
            DbConnection connection = Effort.DbConnectionFactory.CreateTransient();
            
            // use the same DbConnection object to create the context object the test will use.
            this.context = new AppDatabaseContext(connection);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLSWebsite.Core;
using MLSWebsite.Infrastructure;
using System.Text;
using System.Configuration;
using System.Linq;

namespace MLSWebsite.Test
{
    [TestClass]
    public class UserRepoTest
    {
        public UserRepository Repo;

        [TestInitialize]
        public void TestSetup()
        {
            Repo = new UserRepository();
        }

        [TestMethod]
        public void TestRepo()
        {
            Repo.Delete(2);
            var result = Repo.SelectAll();
            Assert.IsNotNull(result);
            int numOfRecords = result.ToList().Count;
            Assert.AreEqual(numOfRecords, 1);
        }
    }
}

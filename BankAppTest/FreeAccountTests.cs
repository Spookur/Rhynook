using BankApp.BLL;
using BankApp.Models;
using BankApp.Models.Responses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppTest
{
    [TestFixture]
    public class FreeAccountTests
    {
        [Test]
        public void CanLoadFreeAccountTestData()
        {
            AccountManager manager = AccountManagerFactory.Create();

            AccountLookupResponse response = manager.LookupAccount("");

            Assert.IsNotNull(response.Account);

            Assert.IsTrue(response.Success);

            Assert.AreEqual("12345", response.Account.AccountNumber);


        }
    }
}

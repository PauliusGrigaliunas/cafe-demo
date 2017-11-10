using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Tests
{
    [TestClass()]
    public class PremiumOperationsTests
    {
        PremiumOperations po = new PremiumOperations();

        private static Random random = new Random();
        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [TestMethod()]
        public void PremiumUserFileCorrectTest()
        {
            AccountOperations ac = new AccountOperations();

            //User details
            string email = RandomString(6) + "@test.net";
            string password = "pass";
            string phone = "8008"; //8008 could be this test's Primary Key when we'll need to delete test data
            string name = "Unit";
            string surname = "Test";
            bool premium = true;

            ac.Register(new User(email, phone, name, surname, premium), password);
            po.WritePremiumUserFile(new LoginDetails(email, password));
 
            Assert.IsNotNull(po.GetPremiumLogin());
        }
    }
}
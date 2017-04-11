using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Tests
{
    [TestClass()]
    public class WalletTests
    {
        [TestMethod()]
        public void CheckWalletTest()
        {
            //Arrange
            Wallet wallet = new Wallet();
            double amount = 21.00;
            bool result;

            //Act
            result = wallet.CheckWallet(amount);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
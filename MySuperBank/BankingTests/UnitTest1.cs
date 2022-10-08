using MySuperBank;
using System;
using Xunit;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            BankAccount account = new BankAccount("Mogboluwaga", 1000);

            //Test for a negative balance.

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw")
            );
        }

        [Fact]
        public void Test3()
        {
            // Test that the initial balances must be positive.
            BankAccount invalidAccount;

            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> invalidAccount = new BankAccount("invalid", -55)
            );
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void ValidMthodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(Address, CustomerId, CustomerName, DateCreated, DateOfBirth, Guest, Email)
        }Assert.AreEqual(Error,"");
    }

}

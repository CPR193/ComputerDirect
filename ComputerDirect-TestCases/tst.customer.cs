using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tst
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void AddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "";

            ACustomer.Address = TestData;

            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]

        public void CustomerIdOK()
        {
            clsCustomer ACustomer = new clsCustomer();


            Int32 TestData = 1;

            ACustomer.CustomerId = TestData;

            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }


        [TestMethod]
        public void CustomerNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "";

            ACustomer.CustomerName = TestData;

            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }



        [TestMethod]
        public void DateCreatedOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            ACustomer.DateAdded = TestData;

            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }
    }


}

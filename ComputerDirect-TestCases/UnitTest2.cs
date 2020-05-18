using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = AnCustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK    = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerId !=21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerName != "")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Email != "")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Address != "")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("21/07/1995"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateCreated()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateCreated != Convert.ToDateTime("21/07/1995"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGuestFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Guest != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}


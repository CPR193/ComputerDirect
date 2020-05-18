using System;

using ComputerDirect_Classes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]

    public class tstCustomer

    {
        [TestMethod]

        public void InstanceOK()

        {

            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);

        }


        public void GuestPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Guest = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Guest, TestData);
        }



        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Address, TestData);
        }


        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }


        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            AnCustomer.CustomerName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }


        public void DateCreatedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateCreated = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateCreated, TestData);
        }


        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }


        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

    }
}
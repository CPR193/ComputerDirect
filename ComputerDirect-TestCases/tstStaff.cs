using System;
using ComputerDirect_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstStaff
    {


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);

        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            clsStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStaff.Address, TestData);
        }
        [TestMethod]
        public void staffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            clsStaff.staffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStaff.staffId, TestData);
        }
        [TestMethod]
        public void staffnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            clsStaff.staffname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStaff.staffname, TestData);
        }
        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            clsStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStaff.PhoneNo, TestData);
        }
        [TestMethod]
        public void eMailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            clsStaff.eMail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsStaff.eMail, TestData);
        }

    }
}
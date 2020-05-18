using System;
using ComputerDirect_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstOrder
    {
        string OrderDate = Convert.ToString(DateTime.Now.Date);
        string OrderTotal = "1";
        string OrderId = "1";
        string CustomerId = "1";
        string StaffId = "1";
        string OrderProgress = "Dispatched";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CustomerId = "0";
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMoreMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CustomerId = Convert.ToString(int.MaxValue);
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string StaffId = "0";
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMoreMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string StaffId = Convert.ToString(int.MaxValue);
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {

                clsOrder AnOrder = new clsOrder();
                String Error = "";
                string DateAdded = "Not a date!";
                Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = Convert.ToString(TestDate);
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = Convert.ToString(TestDate);
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = Convert.ToString(TestDate);
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string OrderDate = Convert.ToString(TestDate);
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }


        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void OrderTotalPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            decimal TestData = 1;
            AnOrder.OrderTotal = TestData;
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }

        [TestMethod]
        public void OrderTotalMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderTotal = "0";
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderTotal = "10000001";
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.StaffId = TestData;
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        [TestMethod]
        public void OrderProgressOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "";
            AnOrder.OrderProgress = TestData;
            Assert.AreEqual(AnOrder.OrderProgress, TestData);
        }

        [TestMethod]
        public void OrderProgressNotEmpty()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderProgress = "";
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderProgressOutOfBounds()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderProgress = "";
            OrderProgress = OrderProgress.PadRight(11, 'a');
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate <= Convert.ToDateTime("01/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderTotal <= 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StaffId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
            Assert.AreEqual(Error, "");
        }
    }

}

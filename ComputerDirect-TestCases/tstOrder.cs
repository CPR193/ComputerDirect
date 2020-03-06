using System;
using ComputerDirect_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstOrder
    {
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderTotal = "1";
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
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
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
        public void OrderLinesPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderLines = TestData;
            Assert.AreEqual(AnOrder.OrderLines, TestData);
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
            Decimal TestData = 1;
            AnOrder.OrderTotal = TestData;
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
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
            if (AnOrder.OrderDate != Convert.ToDateTime("01/01/2020"))
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
            if (AnOrder.OrderTotal != 1)
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
            Error = AnOrder.Valid(OrderDate, OrderTotal);
            Assert.AreEqual(Error, "");
        }
    }

}

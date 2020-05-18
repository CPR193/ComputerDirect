using System;
using ComputerDirect_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
        clsOrderCollection AllOrders = new clsOrderCollection();
        Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderTotal = 200;
            TestItem.CustomerId = 5;
            TestItem.StaffId = 2;
            TestItem.OrderStatus = true;
            TestItem.OrderProgress = "test";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderTotal = 200;
            TestOrder.CustomerId = 5;
            TestOrder.StaffId = 2;
            TestOrder.OrderStatus = true;
            TestOrder.OrderProgress = "test";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderTotal = 200;
            TestItem.CustomerId = 5;
            TestItem.StaffId = 2;
            TestItem.OrderStatus = true;
            TestItem.OrderProgress = "test";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderTotal = 200;
            TestItem.CustomerId = 5;
            TestItem.StaffId = 2;
            TestItem.OrderStatus = true;
            TestItem.OrderProgress = "test";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderTotal = 200;
            TestItem.CustomerId = 5;
            TestItem.StaffId = 2;
            TestItem.OrderStatus = true;
            TestItem.OrderProgress = "test";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            bool Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderTotal = 200;
            TestItem.CustomerId = 5;
            TestItem.StaffId = 2;
            TestItem.OrderStatus = true;
            TestItem.OrderProgress = "test";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderTotal = 250;
            TestItem.CustomerId = 5;
            TestItem.StaffId = 1;
            TestItem.OrderStatus = false;
            TestItem.OrderProgress = "test";
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReportByOrderProgressMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderProgress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderProgressTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            bool OK = true;
            FilteredOrders.ReportByOrderProgress("Pending");
            if (FilteredOrders.Count == 3)
            {
                if (FilteredOrders.OrderList[0].OrderId != 5)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderId != 6)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[2].OrderId != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
        }

        [TestMethod]
        public void ReportByOrderProgressNoneFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            FilteredOrder.ReportByOrderProgress("MoreThan10Char");
            Assert.AreEqual(0, FilteredOrder.Count);
        }
    }
}

using System;
using ComputerDirect_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void ItemNoPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.ItemNo = TestData;
            Assert.AreEqual(AnOrderLine.ItemNo, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderId = TestData;
            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }

        [TestMethod]
        public void OrderLineIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineId = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineId, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.Quantity = TestData;
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineId = 1;
            Found = AnOrderLine.Find(OrderLineId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemNoFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineId = 1;
            Found = AnOrderLine.Find(OrderLineId);
            if (AnOrderLine.ItemNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineId = 1;
            Found = AnOrderLine.Find(OrderLineId);
            if (AnOrderLine.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderLineIdFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineId = 1;
            Found = AnOrderLine.Find(OrderLineId);
            if (AnOrderLine.OrderLineId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineId = 1;
            Found = AnOrderLine.Find(OrderLineId);
            if (AnOrderLine.Quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

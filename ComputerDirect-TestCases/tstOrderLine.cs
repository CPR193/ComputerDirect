using System;
using ComputerDirect_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstOrderLine
    {
        string OrderLineId = "1";
        string OrderId = "1";
        string ItemNo = "1";
        string ItemDescription = "Test Item";
        string Quantity = "1";
        string UnitCost = "15";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIdPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            Int32 TestData = 1;
            AnItem.OrderLineId = TestData;
            Assert.AreEqual(AnItem.OrderLineId, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            Int32 TestData = 1;
            AnItem.OrderId = TestData;
            Assert.AreEqual(AnItem.OrderId, TestData);
        }

        [TestMethod]
        public void ItemNoPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            Int32 TestData = 1;
            AnItem.ItemNo = TestData;
            Assert.AreEqual(AnItem.ItemNo, TestData);
        }

        [TestMethod]
        public void ItemDescriprionPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            String TestData = "Test Item";
            AnItem.ItemDescription = TestData;
            Assert.AreEqual(AnItem.ItemDescription, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            Int32 TestData = 1;
            AnItem.Quantity = TestData;
            Assert.AreEqual(AnItem.Quantity, TestData);
        }

        [TestMethod]
        public void UnitCostPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            Decimal TestData = 1;
            AnItem.UnitCost = TestData;
            Assert.AreEqual(AnItem.UnitCost, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            bool Found = false;
            Int32 OrderLineId = 1;
            Found = AnItem.Find(OrderLineId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindAnyPropertyOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            bool Found = false;
            bool OK = true;
            Int32 OrderLineId = 1;
            string testData = "Asus G1241 Monitor";
            Found = AnItem.Find(OrderLineId);
            if (AnItem.ItemDescription != testData)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsOrderLine AnItem = new clsOrderLine();
            string Error = "";
            Error = AnItem.Valid(OrderId, ItemNo, ItemDescription, Quantity, UnitCost);
            Assert.AreEqual(Error, "");
        }

    }
}

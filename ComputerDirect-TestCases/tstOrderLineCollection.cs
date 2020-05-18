using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ComputerDirect_Classes;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllLines);
        }

        [TestMethod]
        public void OrderLineListOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemNo = 1;
            TestItem.ItemDescription = "Test Item";
            TestItem.Quantity = 1;
            TestItem.UnitCost = 15;
            TestList.Add(TestItem);
            AllLines.OrderLineList = TestList;
            Assert.AreEqual(AllLines.OrderLineList, TestList);
        }

        [TestMethod]
        public void ThisOrderLinePropertyOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemNo = 1;
            TestItem.ItemDescription = "Test Item";
            TestItem.Quantity = 1;
            TestItem.UnitCost = 15;
            AllLines.ThisOrderLine = TestItem;
            Assert.AreEqual(AllLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemNo = 1;
            TestItem.ItemDescription = "Test Item";
            TestItem.Quantity = 1;
            TestItem.UnitCost = 15;
            TestList.Add(TestItem);
            AllLines.OrderLineList = TestList;
            Assert.AreEqual(AllLines.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemNo = 1;
            TestItem.ItemDescription = "Test Item";
            TestItem.Quantity = 1;
            TestItem.UnitCost = 15;
            AllLines.ThisOrderLine = TestItem;
            PrimaryKey = AllLines.Add();
            TestItem.OrderLineId = PrimaryKey;
            AllLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemNo = 1;
            TestItem.ItemDescription = "Test Item";
            TestItem.Quantity = 1;
            TestItem.UnitCost = 15;
            AllLines.ThisOrderLine = TestItem;
            PrimaryKey = AllLines.Add();
            TestItem.OrderId = PrimaryKey;
            AllLines.ThisOrderLine.Find(PrimaryKey);
            AllLines.Delete();
            bool Found = AllLines.ThisOrderLine.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemNo = 1;
            TestItem.ItemDescription = "Test Item";
            TestItem.Quantity = 1;
            TestItem.UnitCost = 15;
            AllLines.ThisOrderLine = TestItem;
            PrimaryKey = AllLines.Add();
            TestItem.OrderLineId = PrimaryKey;
            TestItem.OrderId = 2;
            TestItem.ItemNo = 8;
            TestItem.ItemDescription = "Test Item 2";
            TestItem.Quantity = 2;
            TestItem.UnitCost = 25;
            AllLines.ThisOrderLine = TestItem;
            AllLines.Update();
            AllLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllLines.ThisOrderLine, TestItem);
        }
    }
}

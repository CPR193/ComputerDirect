using System;
using System.Collections.Generic;

namespace ComputerDirect_Classes
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> xOrderLineList = new List<clsOrderLine>();
        clsOrderLine xThisOrderLine = new clsOrderLine();
        public clsOrderLineCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            PopulateArray(DB);
        }

        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return xOrderLineList;
            }
            set
            {
                xOrderLineList = value;
            }
        }

        public clsOrderLine ThisOrderLine
        {
            get
            {
                return xThisOrderLine;
            }
            set
            {
                xThisOrderLine = value;
            }
        }

        public int Count
        {
            get
            {
                return xOrderLineList.Count;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", xThisOrderLine.OrderId);
            DB.AddParameter("@ItemNo", xThisOrderLine.ItemNo);
            DB.AddParameter("@ItemDescription", xThisOrderLine.ItemDescription);
            DB.AddParameter("@Quantity", xThisOrderLine.Quantity);
            DB.AddParameter("@UnitCost", xThisOrderLine.UnitCost);
            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineId", xThisOrderLine.OrderLineId);
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineId", xThisOrderLine.OrderLineId);
            DB.AddParameter("@OrderId", xThisOrderLine.OrderId);
            DB.AddParameter("@ItemNo", xThisOrderLine.ItemNo);
            DB.AddParameter("@ItemDescription", xThisOrderLine.ItemDescription);
            DB.AddParameter("@Quantity", xThisOrderLine.Quantity);
            DB.AddParameter("@UnitCost", xThisOrderLine.UnitCost);
            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void FilterByOrderId(Int32 OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrderLine_FilterByOrderId");
            PopulateArray(DB);
        }




        private void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            xOrderLineList = new List<clsOrderLine>();
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineId"]);
                AnOrderLine.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrderLine.ItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNo"]);
                AnOrderLine.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderLine.UnitCost = Convert.ToDecimal(DB.DataTable.Rows[Index]["UnitCost"]);
                xOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }
    }
}
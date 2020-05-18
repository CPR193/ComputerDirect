using System;
using System.Collections.Generic;

namespace ComputerDirect_Classes
{
    public class clsOrderCollection
    {
        List<clsOrder> xOrderList = new List<clsOrder>();
        clsOrder xThisOrder = new clsOrder();
        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return xOrderList;
            }

            set
            {
                xOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return xOrderList.Count;
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return xThisOrder;
            }

            set
            {
                xThisOrder = value;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderTotal", xThisOrder.OrderTotal);
            DB.AddParameter("@OrderStatus", xThisOrder.OrderStatus);
            DB.AddParameter("@OrderDate", xThisOrder.OrderDate);
            DB.AddParameter("@CustomerId", xThisOrder.CustomerId);
            DB.AddParameter("@StaffId", xThisOrder.StaffId);
            DB.AddParameter("@OrderProgress", xThisOrder.OrderProgress);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", xThisOrder.OrderId);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", xThisOrder.OrderId);
            DB.AddParameter("@OrderTotal", xThisOrder.OrderTotal);
            DB.AddParameter("@OrderStatus", xThisOrder.OrderStatus);
            DB.AddParameter("@OrderDate", xThisOrder.OrderDate);
            DB.AddParameter("@CustomerId", xThisOrder.CustomerId);
            DB.AddParameter("@StaffId", xThisOrder.StaffId);
            DB.AddParameter("@OrderProgress", xThisOrder.OrderProgress);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByOrderProgress(string OrderProgress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderProgress", OrderProgress);
            DB.Execute("sproc_tblOrder_FilterByOrderProgress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            xOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderTotal = Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderTotal"]);
                AnOrder.OrderStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.OrderProgress = Convert.ToString(DB.DataTable.Rows[Index]["OrderProgress"]);
                xOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}
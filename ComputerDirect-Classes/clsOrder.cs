using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerDirect_Classes
{
    public class clsOrder
    {
        private Int32 xCustomerId;
        private DateTime xOrderDate;
        private Int32 xOrderId;
        private Boolean xOrderStatus;
        private Decimal xOrderTotal;
        private Int32 xStaffId;
        public Int32 CustomerId
        {
            get
            {
                return xCustomerId;
            }
            set
            {
                xCustomerId = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return xOrderDate;
            }
            set
            {
                xOrderDate = value;
            }
        }
        public Int32 OrderId
        {
            get
            {
                return xOrderId;
            }
            set
            {
                xOrderId = value;
            }
        }
        public Int32 OrderLines
        {
            get;
            set;
        }
        public Boolean OrderStatus
        {
            get
            {
                return xOrderStatus;
            }
            set
            {
                xOrderStatus = value;
            }
        }
        public Decimal OrderTotal
        {
            get
            {
                return xOrderTotal;
            }
            set
            {
                xOrderTotal = value;
            }
        }
        public Int32 StaffId
        {
            get
            {
                return xStaffId;
            }
            set
            {
                xStaffId = value;
            }
        }

        public bool Find(Int32 OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                xCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                xOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                xOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                xOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderStatus"]);
                xOrderTotal = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderTotal"]);
                xStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string OrderDate, string OrderTotal)
        {
            return "";
        }
    }
}


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
        private string xOrderProgress;

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

        public string OrderProgress
        {
            get
            {
                return xOrderProgress;
            }
            set
            {
                xOrderProgress = value;
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
                xOrderProgress = Convert.ToString(DB.DataTable.Rows[0]["OrderProgress"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string CustomerId, string StaffId, string OrderDate, string OrderTotal, string OrderProgress)
        {
            String Error = "";
            DateTime DateTemp;
            Int32 IdTemp;
            Decimal TotalTemp;

            try
            {
                IdTemp = Convert.ToInt32(CustomerId);
                if (IdTemp < 1)
                {
                    Error = Error + "Customer ID can not be less than 1; ";
                }
                if (IdTemp == int.MaxValue)
                {
                    Error = Error + "Customer ID can not be max int; ";
                }
            }
            catch
            {
                Error = Error + "Customer Id Cannot be empty; ";
            }

            try
            {
                IdTemp = Convert.ToInt32(StaffId);
                if (IdTemp < 1)
                {
                    Error = Error + "Staff ID can not be less than 1; ";
                }
                if (IdTemp == int.MaxValue)
                {
                    Error = Error + "Staff ID can not be max int; ";
                }
            }
            catch
            {
                Error = Error + "Staff Id Cannot be empty; ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date of the order can not be set from the past; ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date of the order can not be set from the future; ";
                }
            }
            catch
            {
                Error = Error + "The Order date is not of a valid date format; ";
            }

            try
            {
                TotalTemp = Convert.ToDecimal(OrderTotal);
                if (TotalTemp <= 0)
                {
                    Error = Error + "Empty order with a total cost of 0 can not be proccessed; ";
                }
                if (TotalTemp > 10000000)
                {
                    Error = Error + "Maximum order amount that can be proccessed is 10,000,000.00; ";
                }
            }
            catch
            {
                Error = Error + "Order Total cannot be empty; ";
            }
            List<string> Stuff = new List<string>();
                
                if (OrderProgress.Length <= 0)
                {
                    Error = Error + "Order progress can not be empty; ";
                }
                if (OrderProgress.Length > 10)
                {
                    Error = Error + "Order progress is limited to a word with a max of 10 character; ";
                }

            return Error;
        }
    }
}


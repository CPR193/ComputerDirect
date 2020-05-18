using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerDirect_Classes
{

    public class clsOrderLine
    {
        private Int32 xOrderLineId;
        private Int32 xOrderId;
        private Int32 xItemNo;
        private string xItemDescription;
        private Int32 xQuantity;
        private decimal xUnitCost;

        public Int32 ItemNo
        {
            get
            {
                return xItemNo;
            }
            set
            {
                xItemNo = value;
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

        public Int32 OrderLineId
        {
            get
            {
                return xOrderLineId;
            }
            set
            {
                xOrderLineId = value;
            }
        }

        public Int32 Quantity
        {
            get
            {
                return xQuantity;
            }
            set
            {
                xQuantity = value;
            }
        }

        public string ItemDescription
        {
            get
            {
                return xItemDescription;
            }
            set
            {
                xItemDescription = value;
            }
        }

        public decimal UnitCost
        {
            get
            {
                return xUnitCost;
            }
            set
            {
                xUnitCost = value;
            }
        }


        public bool Find(Int32 OrderLineId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineId", OrderLineId);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineId");
            if (DB.Count == 1)
            {
                xOrderLineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineId"]);
                xOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                xItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                xItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                xQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                xUnitCost = Convert.ToDecimal(DB.DataTable.Rows[0]["UnitCost"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string Valid(string OrderId, string ItemNo, string ItemDescription, string Quantity, string UnitCost)
        {
            string Error = "";
            Int32 IntTemp;
            Decimal DecTemp;
            try
            {
                IntTemp = Convert.ToInt32(OrderId);
                if (IntTemp < 1)
                {
                    Error = Error + "Order ID cannot be less than 1; ";
                }
                if (IntTemp == int.MaxValue)
                {
                    Error = Error + "Order ID cannot be Max Int; ";
                }
            }
            catch
            {
                Error = Error + "Order ID cannot be empty; ";
            }

            try
            {
                IntTemp = Convert.ToInt32(ItemNo);
                if (IntTemp < 1)
                {
                    Error = Error + "Item Number cannot be less than 1; ";
                }
                if (IntTemp == int.MaxValue)
                {
                    Error = Error + "Item Number cannot be Max Int; ";
                }
            }
            catch
            {
                Error = Error + "Item Number cannot be empty";
            }

            if (ItemDescription.Length < 1)
            {
                Error = Error + "Item Description cannot be empty; ";
            }
            if (ItemDescription.Length > 50)
            {
                Error = Error + "Item Description cannot have more than 50 characters; "; 
            }

            try
            {
                IntTemp = Convert.ToInt32(Quantity);
                if (IntTemp < 1)
                {
                    Error = Error + "Quantity cannot be less than 1; ";
                }
                if (IntTemp == int.MaxValue)
                {
                    Error = Error + "Quantity cannot be Max Int; ";
                }
            }
            catch
            {
                Error = Error + "Quantity cannot be empty; ";
            }

            try
            {
                DecTemp = Convert.ToDecimal(UnitCost);
                if (DecTemp <= 0)
                {
                    Error = Error + "Unit Cost cannot be less than 1; ";
                }
                if (DecTemp > 10000000)
                {
                    Error = Error + "Unit Cost cannot be more than 10,000,000.00; ";
                }
            }
            catch
            {
                Error = Error + "Unit Cost cannot be empty; ";
            }


            return Error;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerDirect_Classes
{

    public class clsOrderLine
    {
        private Int32 xItemNo;
        private Int32 xOrderId;
        private Int32 xOrderLineId;
        private Int32 xQuantity;
        public Int32 ItemNo { get; set; }
        public Int32 OrderId { get; set; }
        public Int32 OrderLineId { get; set; }
        public Int32 Quantity { get; set; }

        public bool Find(Int32 orderId)
        {
            xItemNo = 1;
            xOrderId = 1;
            xOrderLineId = 1;
            xQuantity = 1;
            return true;
        }
    }
}

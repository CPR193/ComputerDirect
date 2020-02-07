using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerDirect_Classes
{
    public class clsOrder
    {
        public Int32 CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public Int32 OrderId { get; set; }
        public Int32 OrderLines { get; set; }
        public bool OrderStatus { get; set; }
        public decimal OrderTotal { get; set; }
        public Int32 StaffId { get; set; }
    }
}


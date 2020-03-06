using System;

namespace ComputerDirect_TestCases
{
    internal class clsCustomer
    {
        public clsCustomer()
        {
        }

        public string Address { get; internal set; }
        public int CustomerID { get; internal set; }
        public string CustomerName { get; internal set; }
        public DateTime DateAdded { get; internal set; }
    }
}
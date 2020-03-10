using System;

namespace ComputerDirect_Classes
{
    public class clsStaff
    {
        public static string staffname;
        public static string eMail;

        public static int staffId { get; set; }
        public static string Address { get; set; }
        public static string PhoneNo { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
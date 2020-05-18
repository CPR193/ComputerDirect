using System;
using ComputerDirect_Classes;


namespace ComputerDirect_TestCases
{
    public class clsCustomer
    {

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;

            }
            set
            {
                mAddress = value;
            }
        }

        public string Valid(object address, object customerId, object customerName, object dateCreated, object dateOfBirth, object guest, object email)
        {
            throw new NotImplementedException();
        }

        private Int32 mCustomerId;
        public int CustomerId
        {
            get
            {
                return CustomerId;

            }
            set
            {
                mCustomerId = value;
            }
        }

        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return CustomerName;

            }
            set
            {
                mCustomerName = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;

            }
            set
            {
                mEmail = value;
            }
        }

        private Boolean mGuest;
        public Boolean Guest
        {
            get
            {
                return Guest;

            }
            set
            {
                mGuest = value;
            }
        }

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;

            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private DateTime mDateCreated;
        public DateTime DateCreated
        {
            get
            {
                return mDateCreated;

            }
            set
            {
                mDateCreated = value;
            }
        }

        internal class DataConnection
        {
            internal void AddParameter(string v, int customerId)
            {
                throw new NotImplementedException();
            }

            internal void Execute(string v)
            {
                throw new NotImplementedException();
            }

            public static implicit operator DataConnection(clsDataConnection v)
            {
                throw new NotImplementedException();
            }
        }

        public bool Find(int customerId)
        {
            throw new NotImplementedException();
        }
    }

   public bool Find(int CustomerId)
    {
        clsCustomer.DataConnection DB = new clsDataConnection();
        DB.AddParameter("@CustomerId", CustomerId);
        DB.Execute("sproc_tblCustomer_FilterbyCustomerId");

        if (DB.Count == 1)
        {
            mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
            mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
            mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
            mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
            mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
            mDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
            mGuest = Convert.ToBoolean(DB.DataTable.Rows[0]["Guest"]);

            return true;

        }

        else
        {
            return false;
        }
    }
}
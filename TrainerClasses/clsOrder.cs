using System;

namespace TrainerClasses
{
    public class ClsOrder
    {
        private DateTime mDate;
        private Int32 mCustomerID;
        private string mNotes;
        private Int32 mONumber;
        private Boolean mComplete;
        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string Notes
        {
            get
            {
                return mNotes;
            }
            set
            {
                mNotes = value;
            }
        }
        public Int32 ONumber
        {
            get
            {
                return mONumber;
            }
            set
            {
                mONumber = value;
            }
        }
        public bool Complete
        {
            get
            {
                return mComplete;
            }
            set
            {
                mComplete = value;
            }
        }
        
        public bool Find(int ONumber)
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ONumber", ONumber);
            DB.Execute("sproc_tblOrder_FilterByONumber");

            if (DB.Count == 1)
            {
                mONumber = Convert.ToInt32(DB.DataTable.Rows[0]["ONumber"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mComplete = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderComplete"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["AdditionalNotes"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DateofEntry"]);
                return true;
            }
            else
            {
                return false;
            }

        }
        public string Valid(string customerid, string notes,string date)
        {
            String Error = "";
            if (notes.Length > 50)
            {
                Error = Error + "The length cannot exceed 50 characters :";
            }
            try
            {
                int cid = Convert.ToInt32(customerid);
                if (cid == 0)
                {
                    Error = Error + "The customer id may not be blank :";
                }

                if (cid > 1000)
                {
                    Error = Error + "The customer id has reached the max value :";
                }
            }
            catch
            {
                Error = Error + "The ONumber was not valid: ";
            }
            
            try
            {
                DateTime dat = Convert.ToDateTime(date);
                if (dat < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past :";
                }

                if (dat > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not valid: ";
            }
            
            return Error;
        }
    }
}

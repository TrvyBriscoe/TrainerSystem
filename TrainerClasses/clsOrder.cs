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
          public int Active { get; set; }
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
    }
}
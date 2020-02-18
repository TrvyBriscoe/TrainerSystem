using System;

namespace TrainerClasses
{
    public class clsOrderline
    {
        public int Active { get; set; }
  
        private Int32 mOLineNumber;
        private Int32 mQuantity;
        private Int32 mShoeID;
        private Int32 mONumber;
        public Int32 OLineNumber {
            get
            {
                return mOLineNumber;
            }
            set
            {
                mOLineNumber = value;
            }
        }
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        public Int32 ShoeID
        {
            get
            {
                return mShoeID;
            }
            set
            {
                mShoeID = value;
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

        public bool Find(int OLineNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OLineNumber", OLineNumber);
            DB.Execute("sproc_tblOrderLine_FilterbyOLineNumber");

            if(DB.Count == 1)
            {
                mOLineNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OLineNumber"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mONumber = Convert.ToInt32(DB.DataTable.Rows[0]["ONumber"]);
                mShoeID = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeID"]);
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
using System;

namespace TrainerClasses
{
    public class clsOrderline
    {
     

        private Int32 mOLineNumber;
        private Int32 mQuantity;
        private Int32 mShoeID;
        private Int32 mONumber;
        
        public Int32 OLineNumber
        {
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
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@OLineNumber", OLineNumber);
            DB.Execute("sproc_tblOrderLine_FilterByOLineNumber");

            if (DB.Count == 1)
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

        public string Valid(string oNumber, string quantity, string shoeID)
        {
            String Error = "";
            try
            { 
            int oNum = Convert.ToInt32(oNumber);
            if (oNum == 0)
            {
                Error = Error + "The Order Number may not be blank :";
            }

            if (oNum > 1000)
            {
                Error = Error + "The Order Number has reached the max value :";
            }
            if(oNum <0)
                {
                    Error = Error + "Order Number cannot be negative";
                }
            }
            catch
            {
                Error = Error + "The ONumber was not valid: ";
            }
            try
            {
                int quan = Convert.ToInt32(quantity);
                if (quan < 0)
                {
                    Error = Error + "The Quantity cannot be negative :";
                }

                if (quan > 5)
                {
                    Error = Error + "You cannot buy more than 5 of the same shoe :";
                }
            }
            catch
            {
                Error = Error + "The Quantity was not valid: ";
            }
            try
            {
                int shoe = Convert.ToInt32(shoeID);
                if (shoe == 0)
                {
                    Error = Error + "The ShoeID may not be blank :";
                }

                if (shoe > 1000)
                {
                    Error = Error + "The ShoeID has reached the max value :";
                }
                if (shoe < 0)
                {
                    Error = Error + "The shoeID cannot be negative";
                }
            }
            catch
            {
                Error = Error + "The ShoeID entered was not valid: ";
            }
            return Error;
        }
    } 
}
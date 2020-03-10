using System;

namespace TrainerClasses
{
    public class clsOrder
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
    }
}
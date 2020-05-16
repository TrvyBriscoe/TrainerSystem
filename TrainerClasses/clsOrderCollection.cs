using System;
using System.Collections.Generic;

namespace TrainerClasses
{
    public class clsOrderCollection
    {
        List<ClsOrder> mOrderList = new List<ClsOrder>();
        ClsOrder mThisOrder = new ClsOrder();

        public List<ClsOrder> OrderList
        {
            get { return mOrderList; }
            set { mOrderList = value; }
        }

        public int Count
        {
            get { return mOrderList.Count; }
            set { }
        }
        public ClsOrder ThisOrder { get { return mThisOrder; } set { mThisOrder = value; } }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            ClsDataConnection DB = new ClsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                ClsOrder AnOrder = new ClsOrder();
                AnOrder.ONumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ONumber"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.Complete = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderComplete"]);
                AnOrder.Notes = Convert.ToString(DB.DataTable.Rows[Index]["AdditionalNotes"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEntry"]);
                mOrderList.Add(AnOrder);
                Index++;

            }

        }

        public int Add()
        {
             ClsDataConnection DB = new ClsDataConnection();
              DB.AddParameter("@AdditionalNotes", mThisOrder.Notes);
             DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
             DB.AddParameter("@OrderComplete", mThisOrder.Complete);
             DB.AddParameter("@DateOfEntry", mThisOrder.Date);
             return DB.Execute("sproc_tblOrder_Insert");
         
            
    }

        public void Delete()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ONumber", mThisOrder.ONumber);
            DB.Execute("sproc_tblOrder_Delete");

        }

        public void Update()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ONumber", mThisOrder.ONumber);
            DB.AddParameter("@AdditionalNotes", mThisOrder.Notes);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderComplete", mThisOrder.Complete);
            DB.AddParameter("@DateOfEntry", mThisOrder.Date);
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}

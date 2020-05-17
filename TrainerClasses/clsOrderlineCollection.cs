

using System;
using System.Collections.Generic;

namespace TrainerClasses
{
    public class clsOrderlineCollection
    {
        List<clsOrderline> mOrderlineList = new List<clsOrderline>();
        clsOrderline mThisOrderline = new clsOrderline();

        public List<clsOrderline> OrderlineList {
            get { return mOrderlineList;}
            set { mOrderlineList = value;}
        }

        public int Count {
            get { return mOrderlineList.Count; }
            set { } }
        public clsOrderline ThisOrderline { get { return mThisOrderline; } set { mThisOrderline = value; } }

        public clsOrderlineCollection()
        {
         
            ClsDataConnection DB = new ClsDataConnection();
            DB.Execute("sproc_tblOrderline_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ONumber", mThisOrderline.ONumber);
            DB.AddParameter("@Quantity", mThisOrderline.Quantity);
            DB.AddParameter("@ShoeID", mThisOrderline.ShoeID);
            return DB.Execute("sproc_tblOrderline_Insert");
        }

        public void Delete()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@OLineNumber", mThisOrderline.OLineNumber);
            DB.Execute("sproc_tblOrderline_Delete");
        }

        public void Update()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@OLineNumber", mThisOrderline.OLineNumber);
            DB.AddParameter("@ONumber", mThisOrderline.ONumber);
            DB.AddParameter("@Quantity", mThisOrderline.Quantity);
            DB.AddParameter("@ShoeID", mThisOrderline.ShoeID);
            DB.Execute("sproc_tblOrderline_Update");
        }

        public void FilterByONum(int ONumber)
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ONumber", ONumber);
            DB.Execute("sproc_tblOrderline_FilterByONumber");
            PopulateArray(DB);
        }
        void PopulateArray(ClsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderlineList = new List<clsOrderline>();
            while (Index < RecordCount)
            {
                clsOrderline AnOrderline = new clsOrderline();
                AnOrderline.OLineNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OLineNumber"]);
                AnOrderline.OLineNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ONumber"]);
                AnOrderline.OLineNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderline.OLineNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeID"]);
                mOrderlineList.Add(AnOrderline);
                Index++;

            }
        }
    }
}
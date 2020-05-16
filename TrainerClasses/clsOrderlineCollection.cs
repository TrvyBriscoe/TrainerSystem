

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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            ClsDataConnection DB = new ClsDataConnection();
            DB.Execute("sproc_tblOrderline_SelectAll");
            RecordCount = DB.Count;

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
    }
}
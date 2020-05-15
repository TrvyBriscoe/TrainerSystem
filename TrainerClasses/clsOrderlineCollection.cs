

using System;
using System.Collections.Generic;

namespace TrainerClasses
{
    public class clsOrderlineCollection
    {
        List<clsOrderline> mOrderlineList = new List<clsOrderline>();


        public List<clsOrderline> OrderlineList {
            get { return mOrderlineList;}
            set { mOrderlineList = value;}
        }

        public int Count {
            get { return mOrderlineList.Count; }
            set { } }
        public clsOrderline ThisOrderline { get; set; }

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
    }
}
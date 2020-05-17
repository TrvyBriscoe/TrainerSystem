using System;

namespace TrainerClasses
{
    public class ClsStock
    {
        public ClsStock()
        {

        }



        public Int32 MShoeID;
        private string MName;
        public DateTime MRelease;
        public int MQuantityStock;
        public int MPriceStock;
        public int MSize;

        public bool Find(int shoeId)
        {
            ClsDataConnection DB = new ClsDataConnection();

            DB.AddParameter("@ShoeID", ShoeID);

            DB.Execute("sproc_tblStock_FilterByShoeID");

            if (DB.Count == 1)
            {
                MShoeID = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeID"]);
                MName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                MRelease = Convert.ToDateTime(DB.DataTable.Rows[0]["Release"]);
                MQuantityStock = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                MPriceStock = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                MSize = Convert.ToInt32(DB.DataTable.Rows[0]["Size"]);
                /**ShoeID = 2;
                MName = "A";
                MRelease = Convert.ToDateTime("16/9/2015");
                MQuantityStock = 3;
                MPriceStock = 4;
                MSize = 5;**/
                return true;
            }

            else

            {
                return false;
            }
        }

        /**public string Valid (string Name, DateTime Release, string Quantity, string Price, string Size);**/
        

        

        public Int32 ShoeID
        {
            get
            {
                return MShoeID;

            }
            set
            {
                MShoeID = value;
            }
        }

        public string Name
        {
            get
            {
                return MName;

            }
            set
            {
                MName = value;
            }
        }

        public DateTime Release
        {
            get
            {
                return MRelease;

            }
            set
            {
                MRelease = value;
            }
        }

        public int QuantityStock
        {
            get
            {
                return MQuantityStock;

            }
            set
            {
                MQuantityStock = value;
            }
        }

        public int PriceStock
        {
            get
            {
                return MPriceStock;

            }
            set
            {
                MPriceStock = value;
            }
        }

        public int Size
        {
            get
            {
                return MSize;

            }
            set
            {
                MSize = value;
            }
        }

        public string Valid(string name, string release, string quantity, string price, string size)
        {
            return "";
        }
    }
}
using System;
using System.Collections.Generic;

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
            //try
            //{
                ClsDataConnection DB = new ClsDataConnection();


            DB.AddParameter("@ShoeID", shoeId); //Another mistake here ShoeID spelling...
            DB.Execute("sproc_tblStock_FilterByShoeID"); //This store procedure is not created... thats why sql connection error given.... wait..

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
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

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
                String Error = " ";
                DateTime DateTemp;
                Int32 Num;

                if (name.Length == 0)
                {
                    Error = Error + "The name may not be blank";
                }

                if (name.Length > 6)
                {
                Error = Error + " The name must be less than 6 characters : ";
                }

              //try
              //{
                    DateTemp = Convert.ToDateTime(release);

                    if (DateTemp < DateTime.Now.Date)
                    {
                        Error = Error + "The date cannot be in the past : ";
                    }

                    if (DateTemp > DateTime.Now.Date)
                    {
                        Error = Error + "The date cannot be in the future : ";

                    }
            //  }

            //   catch
            //{

            //    Error = Error + "The date was not valid date: ";
            //}

                Num = Convert.ToInt32(quantity);
                if (Num < -2147483648)
            {
                Error = Error + "The number cannot be smaller than -2147483648";
            }


                return Error;

            

        }

        public static implicit operator List<object>(ClsStock v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ClsStock(List<ClsStock> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ClsStock(int v)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using TrainerClasses;

namespace TrainerTesting
{
    public class ClsStockCollection
    {
        List<ClsStock> MAddressList;
        //private int MCount;
        ClsStock mThisStock = new ClsStock();
        
        public List<ClsStock> ThisAddressList { get; internal set; }

        public List<ClsStock> AddressList
        {
            get
            {
                return MAddressList;
            }
            set
            {
                MAddressList = value;
            }
        }

        public int Count
        {
            get
            {
                return MAddressList.Count;
            }
            set
            {
               
            }
        }
        public ClsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            
               
     
             set
            {
                mThisStock = value;
            }
         
         }

        public ClsStockCollection()
        {
            ClsStock TestItem = new ClsStock();

            TestItem.ShoeID = 1;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 1;
            TestItem.PriceStock = 1;
            TestItem.Size = 1;

            MAddressList.Add(TestItem);

            TestItem = new ClsStock();

            TestItem.ShoeID = 2;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 2;
            TestItem.PriceStock = 12;
            TestItem.Size = 2;

            MAddressList.Add(TestItem);
        }

        public int Add()
        {
            mThisStock.ShoeID = 1;

            return mThisStock.ShoeID;
        }

        public void Delete()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ShoeID", mThisStock.ShoeID);
            DB.Execute("sproc_tblStock_Update");

        }

        public void Update()
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ShoeID", mThisStock.ShoeID);
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Release", mThisStock.Release);
            DB.AddParameter("@Quantity", mThisStock.QuantityStock);
            DB.AddParameter("@Price", mThisStock.PriceStock);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.Execute("sproc_tblStock_Update");
        }
    }
}
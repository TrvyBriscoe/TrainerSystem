using System;

namespace TrainerClasses
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public int Shoeid { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public int QuantityStock { get; set; }
        public int PriceStock { get; set; }
        public int Size { get; set; }
    }
}
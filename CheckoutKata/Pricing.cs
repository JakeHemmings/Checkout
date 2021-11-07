using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckoutKata
{
    class Pricing
    {
        private Items item = new Items();
        private double itemA_Price = 10.00;
        private double itemB_Price = 15.00;
        private double itemB_Promo_Price = 40.00;
        private double itemC_Price = 40.00;
        private double itemD_Price = 55.00;
        public bool PromoApplied = false;

        public double CalculatePrice(string item, int numItems)
        {
            double price = 0.0;
            double saving = 0.0;

            switch ((item, numItems))
            {
                case ("b", 3):
                    price = itemB_Promo_Price * numItems;
                    PromoApplied = true;
                    break;
                case ("b", < 3):
                    price = itemB_Price * numItems;
                    break;
                case ("d", > 1):
                    saving = itemD_Price / 4;
                    price = (itemD_Price * 2) - saving;
                    PromoApplied = true;
                    break;
                case ("d", < 2):
                    price = itemD_Price * numItems;
                    break;
                case ("a", > 0):
                    price = itemA_Price * numItems;
                    break;
                case ("c", > 0):
                    price = itemC_Price * numItems;
                    break;
            }

            return price;
        }
    }
}

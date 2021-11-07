using System;

namespace CheckoutKata
{
    class Checkout
    {
        public bool ValidateInputItem(string item)
        {
            string[] itemArray = new string[] { "a", "b", "c", "d" };
            foreach(var _item in itemArray)
            {
                if (item == _item)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Pricing pricing = new Pricing();
            Checkout checkout = new Checkout();
            string item = string.Empty;
            int numItems = 0;
            double price = 0.0;

            Console.Write("Select item to add to basket: either a, b, c or d: ");
            item = Console.ReadLine();
            while(!checkout.ValidateInputItem(item))
            {
                Console.Write("Enter either a, b, c or d: ");
                item = Console.ReadLine();
            }

            Console.Write("Number of items to add to basket: ");
            string numberOfItems = Console.ReadLine();
            if(numberOfItems != null)
            {
                numItems = int.Parse(numberOfItems);
                price = pricing.CalculatePrice(item, numItems);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Item: " + item);
            Console.WriteLine("Number added: " + numItems);
            if (pricing.PromoApplied)
            {
                Console.WriteLine("Total Cost (Promo Applied): " + price);
            }
            else
            {
                Console.WriteLine("Total Cost: " + price);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.ResetColor();
            Console.Write("Enter another item? y/n: ");
            string continueApp = Console.ReadLine();
        }
    }
}

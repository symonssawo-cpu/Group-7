using System;

namespace CreditEvaluator
{

    class CreditEvaluator
    {
        static void Main()
        {
            Console.Write("Enter the number of customers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter Credit Limit: ");
                double limit = double.Parse(Console.ReadLine());

                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());


                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                double totalPurchase = price * qty;

                while (totalPurchase > limit)
                {
                    Console.WriteLine("Sorry you cannot purchase goods worthy such a value on credit.");
                    Console.Write("Re-enter Quantity: ");
                    qty = int.Parse(Console.ReadLine());
                    totalPurchase = price * qty;
                }

                Console.WriteLine($"Thank You for purchasing from us. Purchase Value: {totalPurchase}");
            }
        }
    }
}
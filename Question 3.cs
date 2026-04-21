using System;

namespace CreditEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Credit Worthiness Evaluation System ===\n");

            // Get number of customers
            Console.Write("Enter the number of customers (n): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\n--- Customer {i} ---");

                // Read credit limit
                Console.Write("Enter credit limit: ");
                double creditLimit = double.Parse(Console.ReadLine());

                // Read price of the item
                Console.Write("Enter price of the item: ");
                double price = double.Parse(Console.ReadLine());

                double quantity;
                double totalValue;

                // Keep asking for quantity until the total is within credit limit
                while (true)                                          
                {
                    Console.Write("Enter quantity: ");
                    quantity = double.Parse(Console.ReadLine());

                    totalValue = price * quantity;

                    if (totalValue > creditLimit)
                    {
                        Console.WriteLine("Sorry you cannot purchase goods worthy such a value on credit");
                        // Loop again to re-enter quantity
                    }
                    else
                    {
                        Console.WriteLine("Thank You for purchasing from us");
                        Console.WriteLine($"Value of the purchase: {totalValue}");
                        break; // Exit the while loop when purchase is approved
                    }
                }

            } 

            Console.WriteLine("\n=== All customers processed. Thank you! ===");  
            Console.ReadKey();
        }
    }
}
using System;

namespace CreditEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Credit Worthiness Evaluation System ===\n");

            // Get number of customers
            int n = GetPositiveInteger("Enter the number of customers (n): ");

            for (int customer = 1; customer <= n; customer++)
            {
                Console.WriteLine($"\n--- Customer {customer} ---");

                // Read credit limit
                decimal creditLimit = GetPositiveDecimal("Enter customer's credit limit: ");

                bool purchaseCompleted = false;

                while (!purchaseCompleted)
                {
                    // Read price per item
                    decimal price = GetPositiveDecimal("Enter price per item: ");

                    // Read quantity
                    int quantity = GetPositiveInteger("Enter quantity to purchase: ");

                    // Calculate total value of goods
                    decimal totalValue = price * quantity;

                    Console.WriteLine($"\nTotal value of goods: {totalValue:C}");

                    if (totalValue > creditLimit)
                    {
                        Console.WriteLine("Sorry you cannot purchase goods worthy such a value on credit");
                        Console.WriteLine("Please reduce the quantity and try again.\n");
                        // Loop continues - customer re-enters quantity (and price if needed)
                    }
                    else
                    {
                        Console.WriteLine("Thank You for purchasing from us");
                        Console.WriteLine($"Purchase value: {totalValue:C}");
                        purchaseCompleted = true;
                    }
                }
            }

            Console.WriteLine("\n=== All customers processed. Thank you! ===");
            Console.ReadKey();
        }

        // Helper method to get positive integer input
        static int GetPositiveInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }
        }

        // Helper method to get positive decimal input
        static decimal GetPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Invalid input! Please enter a positive number.");
            }
        }
    }
}
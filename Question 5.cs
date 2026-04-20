using System;

class SalesProgram
{
    static void Main()
    {
        int numSalesmen = 10;
        int numItems = 5;

        string[] names = new string[numSalesmen];
        int[,] sales = new int[numSalesmen, numItems];
        int[] totalSales = new int[numSalesmen];
        int grandTotal = 0;

        // Input section
        for (int i = 0; i < numSalesmen; i++)
        {
            Console.Write("Enter name of salesman {0}: ", i + 1);
            names[i] = Console.ReadLine();

            for (int j = 0; j < numItems; j++)
            {
                Console.Write("Enter sales for Item {0}: ", j + 1);
                sales[i, j] = Convert.ToInt32(Console.ReadLine());
                totalSales[i] += sales[i, j];
            }

            grandTotal += totalSales[i];
            Console.WriteLine();
        }

        // Output section
        Console.WriteLine("\nName\tItem1\tItem2\tItem3\tItem4\tItem5\tTotalSales");
        Console.WriteLine("-------------------------------------------------------------");

        for (int i = 0; i < numSalesmen; i++)
        {
            Console.Write(names[i] + "\t");

            for (int j = 0; j < numItems; j++)
            {
                Console.Write(sales[i, j] + "\t");
            }

            Console.WriteLine(totalSales[i]);
        }

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Grand Total: " + grandTotal);
    }
}
using System;
namespace NestedLoopsPattern
{
    class Program
    {
        static void Main()
        {
            //  6 rows in total
            for (int row = 1; row <= 6; row++)
            {
                for (int col = 1; col <= 6; col++)
                {
                    //  decide whether to print '&' or '*'
                    if (row == 1 || row == 6)                    // First and last row: all &
                    {
                        Console.Write("& ");
                    }
                    else if (col == row)                         // On the diagonal (where row number == column number)
                    {
                        Console.Write("& ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();   // Move to the next line after each row
            }

            Console.ReadKey();  
        }
    }
}

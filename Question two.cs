using System;

class Program
{
    static void Main()
    {
        int size = 6;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                // Condition for printing '&'
                if (row == 0 || row == size - 1 || row == col)
                {
                    Console.Write("& ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine(); // Move to next line after each row
        }
    }
}
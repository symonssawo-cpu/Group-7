using System;

class AreaCalculator
{
    static void Main()
    {
        int attempts = 0;
        bool validChoice = false;

        while (attempts < 3 && !validChoice)
        {
            Console.WriteLine("Choose a shape to calculate area:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.Write("Enter your choice (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Triangle
                    validChoice = true;
                    Console.Write("Enter base: ");
                    double baseValue = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());

                    double triangleArea = 0.5 * baseValue * height;
                    Console.WriteLine("Area of Triangle = " + triangleArea);
                    break;

                case "2": // Rectangle
                    validChoice = true;
                    Console.Write("Enter length: ");
                    double length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter breadth: ");
                    double breadth = Convert.ToDouble(Console.ReadLine());

                    double rectangleArea = length * breadth;
                    Console.WriteLine("Area of Rectangle = " + rectangleArea);
                    break;

                case "3": // Circle
                    validChoice = true;
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    double circleArea = Math.PI * radius * radius;
                    Console.WriteLine("Area of Circle = " + circleArea);
                    break;

                default:
                    attempts++;
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        if (!validChoice)
        {
            Console.WriteLine("Too many invalid attempts. Program terminated.");
        }
    }
}

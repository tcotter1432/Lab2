using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while(isRunning == true) {
                Console.Write("Enter a Length: ");
                string stringLength = Console.ReadLine();
                Console.Write("Enter a Width: ");
                string stringWidth = Console.ReadLine();
                Console.Write("Enter a Height: ");
                string stringHeight = Console.ReadLine();

                double length = double.Parse(stringLength);
                double height = double.Parse(stringHeight);
                double width = double.Parse(stringWidth);

                double area = length * width;
                double perimeter = (length * 2) + (width * 2);
                double volume = length * width * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.Write("Would you like to calculate another room? (y/n)");
                string toContinue = Console.ReadLine();
                if (toContinue == "y"){
                    isRunning = true;
                } else {
                    isRunning = false;
                }
            }
        }
    }
}

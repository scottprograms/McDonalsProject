using System;

namespace McDonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveThru McDonaldsDriveThru = new DriveThru();
            float TotalCost = 0;
            Console.WriteLine("Welcome to McDonald's what will you be having today?");
            Console.WriteLine("Number 1: $5");
            Console.WriteLine("Number 2: $3");
            Console.WriteLine("Number 3: $1.09");
            Console.WriteLine("Number 4: $7.50");
            char input;
            input = Console.ReadKey().KeyChar;
            Console.WriteLine(System.Environment.NewLine);
            //This is so i get a space after input

            TotalCost = TotalCost + McDonaldsDriveThru.Order(input);
            Console.WriteLine("Would this complete your order?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().KeyChar;

            bool keepGoing = true;

            while (keepGoing)
            {

            }
            Console.WriteLine(TotalCost);
            


        }
    }
}

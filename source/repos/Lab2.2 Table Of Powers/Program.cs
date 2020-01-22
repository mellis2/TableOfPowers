using System;

namespace Lab2._2_Table_Of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            string selection = "y";

            while(selection == "y") 
            {
                Console.Write("Enter an integer: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Number\t\tSquared\t\tCubed");
                Console.WriteLine($"=======\t\t========\t=======");

                for(int i = 1; i <= num; i++)
                {
                    Console.WriteLine(i + "\t\t" + (i * i) + "\t\t" + (i * i * i));
                }

                Console.WriteLine("Continue? (y/n): ");
                selection = Console.ReadLine();
            }

        }
        
    }
}

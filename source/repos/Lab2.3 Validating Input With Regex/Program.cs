using System;
using System.Text.RegularExpressions;

namespace Lab2._3_Validating_Input_With_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a valid Name: ");
            string nameInput = Console.ReadLine();
            string name = nameInput;

            string pattern = @"[A-Z][A-Za-z]{0,30}";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Name valid");
            }

            else 
            {
                Console.WriteLine("Sorry, name is not valid!");
            }

            Console.Write("Please enter a valid email: ");
            string emailInput = Console.ReadLine();
            string email = emailInput;

            string pattern2 = @"\b([A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}.[A-Za-z]{2,3})\b";

            if (Regex.IsMatch(email, pattern2))
            {
                Console.WriteLine("Email is valid!");
            }

            else
            {
                Console.WriteLine("Sorry, email is not valid!");
            }

            Console.Write("Please enter a valid phone number: ");
            string phoneInput = Console.ReadLine();
            string phone = phoneInput;

            string pattern3 = @"\d\d\d[-.]\d\d\d[-.]\d\d\d\d";
            

            if (Regex.IsMatch(phone, pattern3))
            {
                Console.WriteLine("phone number is valid!");
            }

            else
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }
            Console.Write("Please enter a valid date: ");
            string dateInput = Console.ReadLine();
            string date = dateInput;

            string pattern4 = @"\d\d[/]\d\d[/]\d\d\d\d";


            if (Regex.IsMatch(phone, pattern4))
            {
                Console.WriteLine("Date is valid!");
            }

            else
            {
                Console.WriteLine("Sorry, date is not valid!");
            }
        }
    }
}

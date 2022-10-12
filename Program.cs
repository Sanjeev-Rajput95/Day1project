using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjeevDay1project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Enter first name: ");
            Console.WriteLine("Enter last name : ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + FirstName);
            Console.WriteLine("Username is: " + LastName);
        }
    }
}

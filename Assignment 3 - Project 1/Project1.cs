using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3___Project_1
{
    class Project1
    {
        static void Main(string[] args)
        {
            string burger = ("1. Would you like to eat a Burger? ");
            string pizza = ("2. Would you like to eat Pizza? ");
            string option;
            int optionb;

            Console.WriteLine("Welcome to Project 1");
            Console.WriteLine("--------------------");

            Console.WriteLine("What would you like to eat? ");
            Console.WriteLine(burger);
            Console.WriteLine(pizza);
            Console.WriteLine();

            Console.Write("Choose an option (1-3): ");
            option = Console.ReadLine();
            optionb = Convert.ToInt32(option);


            Console.WriteLine("--------------------------");
            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

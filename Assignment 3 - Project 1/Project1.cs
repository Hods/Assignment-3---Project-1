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
            string pizzaburger = ("3. Perhaps you would like both?");
            string fries = ("4. Looking to eat some french fries, mon ami");
            string exit = ("5. I am not hungry");
            string option;
            int selection = 0;
            while (selection != 5)
            {

                Console.WriteLine("Welcome to Project 1");
                Console.WriteLine("--------------------");

                Console.WriteLine("What would you like to eat? ");
                Console.WriteLine(burger);
                Console.WriteLine(pizza);
                Console.WriteLine(pizzaburger);
                Console.WriteLine(fries);
                Console.WriteLine(exit);
                Console.WriteLine();
                Console.Write("Choose an option (1-5): ");
                option = Console.ReadLine();
                selection = Convert.ToInt32(option);

                Console.WriteLine("--------------------------");
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("One Burger, coming right up!");
                        break;
                    case 2:
                        Console.WriteLine("You must love pizza!");
                        break;
                    case 3:
                        Console.WriteLine("I hope you enjoy your pizza and burger!");
                        break;
                    case 4:
                        Console.WriteLine("Enjoy the french fries!");
                        break;
                    case 5:
                        Console.WriteLine("No worries. Come by another day.");
                        break;
                    default:
                        Console.WriteLine("Sorry, we don't serve that here my friend.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

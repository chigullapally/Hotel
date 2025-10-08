using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int choice = 0;
       
            while(choice != 5)
            {
                Console.WriteLine("select the menu below:\n1.Idli - 30/-\n2.Dosa-40/-\n3.Vada-45/-\n4.PavBaji-60/-\n5.Exit");
                int total = 0;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("you have selected idli");
                            Console.WriteLine("enter the quantity");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            int price = 30;
                            total = price * quantity;
                            Console.WriteLine("your total bill of Idli " + total);
                            break;
                        case 2:
                            Console.WriteLine("you have selected Dosa");
                            Console.WriteLine("enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            price = 40;
                            total = price * quantity;
                            Console.WriteLine("your total bill of Dosa " + total);
                            break;
                        case 3:
                            Console.WriteLine("you have selected Vada");
                            Console.WriteLine("enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            price = 45;
                            total = price * quantity;
                            Console.WriteLine("your total bill of Vada " + total);
                            break;
                        case 4:
                            Console.WriteLine("you have selected PavBaji");
                            Console.WriteLine("enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            price = 60;
                            total = price * quantity;
                            Console.WriteLine("your total bill of PavBaji " + total);
                            break;
                        case 5:
                            Console.WriteLine("Thank you for visiting. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid menu option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number corresponding to the menu options.");
                }


            }
        }
    }
}

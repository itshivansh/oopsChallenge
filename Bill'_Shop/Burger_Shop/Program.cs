using Burger_Shop.Constants;
using Burger_Shop.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Burger_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Welcome To Bill's Burger";
            #region Start
            Start:
            Console.WriteLine($"Welcome\nPlease select from the Available Burgers ::\n1. {Additions.Hamburger}\n2. {Additions.HealthyBurger}\n3. {Additions.DeluxeBurger}");
            int burgerChoice = Convert.ToInt32(Console.ReadLine());
            switch (burgerChoice)
            {
                case (int)(Additions.Hamburger) :
                    Hamburger ham = new Hamburger();
                    ham.Display();
                    string str = ham.ReadAdditions();
                    double cost = ham.Total(str);
                    Console.WriteLine($"Total cost is::{ cost }\n\n");
                        break;
                case (int)(Additions.HealthyBurger):
                    Healthy healthy = new Healthy();
                    healthy.Display();
                    string st = healthy.ReadAdditions();
                    double cost_ = healthy.Total(st);
                    Console.WriteLine($"Total cost is::{ cost_ }\n\n");
                    break;
                case (int)(Additions.DeluxeBurger):
                    Deluxe del = new Deluxe();
                    del.Display();
                    string sr = del.ReadAdditions();
                    double _cost = del.Total(sr);
                    Console.WriteLine($"Total cost is::{ _cost }\n\n");
                    break;
            }
            goto Start;
            #endregion
            //Console.WriteLine("Hello World!");
        }
    }
}

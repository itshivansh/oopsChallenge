using System;

namespace burgers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BillBurger";
            int total_Price;
            int base_price = 50;
            int meat_price = 300;
            int price = base_price + meat_price;
            Console.WriteLine("Welcome to BILLS Burger!\nWhich type of Burger do you want?\n1. Basic\n2. Healthy\n3. Deluxe");
            Console.WriteLine($"base price of the hamburger plus meat is ::{350}");
            string str = Console.ReadLine();
            if (str == "1")
            {
                Console.WriteLine("Which additions would you preffer?\na. lettuce (price-20)\nb. tomato (price-15)\nc. carrot (price-10)\nd. cheese(price-25)");
                string addings = Console.ReadLine();
                switch (addings)
                {
                    case "a":
                        total_Price = price + 20;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "b":
                        total_Price = price + 15;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "c":
                        total_Price = price + 10;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "d":
                        total_Price = price + 25;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    default:
                        Console.WriteLine("Thanks for visiting us");
                        break;
                }

            }
            else if (str == "2")
            {
                //additional price for brown rye bread is 20
                price = price + 20;
                Console.WriteLine("Which additions would you preffer?\na. lettuce (price-20)\nb. tomato (price-15)\nc. carrot (price-10)\nd. cheese (price-25)\ne. ketchup (price-10)\nf. egg (price-30)");
                string addings = Console.ReadLine();
                switch (addings)
                {
                    case "a":
                        total_Price = price + 20;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "b":
                        total_Price = price + 15;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "c":
                        total_Price = price + 10;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "d":
                        total_Price = price + 25;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "e":
                        total_Price = price + 10;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "f":
                        total_Price = price + 30;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    default:
                        Console.WriteLine("Thanks for visiting us");
                        break;
                }
            }
             else if (str == "3")
            {
                Console.WriteLine("Which additions would you preffer?\navailable only two\nA. chips (price-20)\nB. drinks (price-50)");
                string addings = Console.ReadLine();
                switch (addings)
                {
                    case "A":
                        total_Price = price + 20;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    case "b":
                        total_Price = price + 50;
                        Console.WriteLine($"Total price is ::{total_Price}\nDo you wanna proceed further?\nPress Y or N");
                        break;
                    default:
                        Console.WriteLine("Thanks for visiting us");
                        break;
                }

            }
        }
    }
}

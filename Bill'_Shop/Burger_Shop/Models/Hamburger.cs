using Burger_Shop.Constants;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace Burger_Shop.Models
{
    class Hamburger
    {
        public double total = 0;
        public string breadRollType { get; set; }
        public string name { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"We have Following additions.Please make your choice by choosing Y or N::\n{Additions.lettuce}(Y or N)\n{Additions.tomato}(Y or N)\n{Additions.carrot}(Y or N)\n{Additions.cheese}(Y or N)\n");
        }
        public virtual string ReadAdditions()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(Console.ReadLine().ToUpper());
            }
            return Convert.ToString(sb);
            //string islettuce = Console.ReadLine().ToUpper();
            //if (islettuce == "Y")
            //{
            //    bool lettuce = true;
            //}
            //else
            //{
            //    bool lettuce = false;
            //}
            //string isTomato = Console.ReadLine().ToUpper();
            //if (isTomato == "Y")
            //{
            //    bool tomato = true;
            //}
            //else
            //{
            //    bool tomato = false;
            //}
            //string isCarrot = Console.ReadLine().ToUpper();
            //if (isCarrot == "Y")
            //{
            //    bool carrot = true;
            //}
            //else
            //{
            //    bool carrot = false;
            //}
            //string isCheese = Console.ReadLine().ToUpper();
            //if (isCheese == "Y")
            //{
            //    bool cheese = true;
            //}
            //else
            //{
            //    bool cheese = false;
            //}
        }

        // public virtual double Total (bool lettuce,bool tomato ,bool carrot,bool cheese)
        public virtual double Total(string addings)
        {
            this.total = 200;
            this.breadRollType = "simple";
            this.name = "Hamburger";
            Console.WriteLine($"breadtype::{breadRollType}\nProcessing order ::{name}");
  
            if (addings[0]=='Y')
            {
                total += (double)Additions.lettuce;
                total += 10;
            }
            if (addings[1] == 'Y')
            {
                total += (double)Additions.tomato;
            }
            if (addings[2] == 'Y')
            {
                total += (double)Additions.carrot;
            }
            if (addings[3] == 'Y')
            {
                total += (double)Additions.cheese;
            }
            //Console.WriteLine(total);
            return total;
        }
    }
}

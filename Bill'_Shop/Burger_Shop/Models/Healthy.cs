using Burger_Shop.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burger_Shop.Models
{
    class Healthy:Hamburger
    {
        public override void Display()
        {
            Console.WriteLine($"We have Following additions.Please make your choice by choosing Y or N::\n{Additions.lettuce}(Y or N)\n{Additions.tomato}(Y or N)\n{Additions.carrot}(Y or N)\n{Additions.cheese}(Y or N)\n{Additions.ketchup}(Y or N)\n{Additions.egg}(Y or N)");
        }
        public override string ReadAdditions()
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append(Console.ReadLine().ToUpper());
            }
            return Convert.ToString(sb);
        }
        public override double Total(string addings)
        {
            this.breadRollType = "Special";
            this.name = "HealthyBurger";
            this.total = 250;
            Console.WriteLine($"breadtype::{breadRollType}\nProcessing order ::{name}");
            if (addings[0] == 'Y')
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
            if (addings[4] == 'Y')
            {
                total += (double)Additions.ketchup;
            }
            if (addings[5] == 'Y')
            {
                total += (double)Additions.egg;
            }return total;
        }
    }
}

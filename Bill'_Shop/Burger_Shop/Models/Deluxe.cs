using Burger_Shop.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burger_Shop.Models
{
    class Deluxe:Hamburger
    {
       // Hamburger deluxe = new Hamburger();
        public override void Display()
        {
            Console.WriteLine($"Only two addons available.Please make your choice by choosing Y or N::\n{Additions.chips}(Y or N)\n{Additions.drinks}(Y or N)");
        }
        public override string ReadAdditions()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                sb.Append(Console.ReadLine().ToUpper());
                //return base.ReadAdditions();
            }
            return Convert.ToString(sb);
        }
        public override double Total(string addings)
        {
            this.name = "Deluxe";
            this.total = 300;
            this.breadRollType = "Brown Rye Bread";
            Console.WriteLine($"breadtype::{breadRollType}\nProcessing order ::{name}");
            if (addings[0] == 'Y')
            {
                total += (double)Additions.chips;
            }
            if (addings[1] == 'Y')
            {
                total += (double)Additions.drinks;
            }
            return total;
        }
    }
}

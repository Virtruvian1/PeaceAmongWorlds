using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Rick = new Character("Rick", 18, 50);
            TradeShop EarthShop = new TradeShop(1, 2, 3, 4, 5);
            EarthShop.TradeMenu(Rick.money);

            
        }
    }
}

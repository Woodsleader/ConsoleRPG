using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Item
    {
        public string Name { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }

        // Constructor

        public Item (string name, int buyPrice, int sellPrice)
        {
            Name = name;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
        }
    }
}

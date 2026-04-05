using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Armor : Item, IEquippable
    {
        public int Defense { get; set; }
        public int Dodge { get; set; }

        // Constructor

        public Armor(string name, int defense, int dodge, int buyPrice, int sellPrice) : base (name, buyPrice, sellPrice)
        {
            Defense = defense;
            Dodge = dodge;
        }
    }
}

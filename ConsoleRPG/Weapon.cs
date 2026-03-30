using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Weapon : Item
    {
        public int Damage { get; set; }
        public int Speed { get; set; }

        // Constructor

        public Weapon (string name, int damage, int speed, int buyPrice, int sellPrice) : base (name, buyPrice, sellPrice)
        {
            Damage = damage;
            Speed = speed;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Weapon : Item , IEquippable
    {
        public int Damage { get; set; }
        public int Speed { get; set; }

        // Constructor

        public Weapon (string name, int damage, int speed, int buyPrice, int sellPrice) : base (name, buyPrice, sellPrice)
        {
            Damage = damage;
            Speed = speed;
        }

        public void Equip(Hero hero)
        {
            throw new NotImplementedException();
        }

        public void Unequip(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}

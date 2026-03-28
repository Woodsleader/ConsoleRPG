using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Hero
    {
        public int MaxHealth { get; set; }
        private int _health;
        public int Health
        {
            get { return _health; }
            set
            {
                if (value > MaxHealth) _health = MaxHealth;
                else if (value < 0) _health = 0;
                else _health = value;
            }
        }
        public string Name { get; private set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxExperience => Experience + (Level * 50);
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Evasion { get; set; }
        public int Speed { get; set; }

        // Constructor
        public Hero()
        {
            Level = 1;
        }

        // Methods

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void TakeHealing(int heal)
        {
            Health += heal;
        }
    }
}

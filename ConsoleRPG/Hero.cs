using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Hero
    {
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public Inventory BackPack { get; set; }
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
        public int MaxExperience => 100 + (Level * 50);
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Evasion { get; set; }
        public int Speed { get; set; }
        public int Gold { get; set; }

        // Constructor
        public Hero()
        {
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = 100;
            Attack = 1;
            Defense = 1;
            Evasion = 0;
            Speed = 1;
            Gold = 100;
            BackPack = new Inventory();
            Weapon RustySword = new Weapon("Rusty sword", 1, 1, 1, 0);
            BackPack.Items.Add(RustySword);
            Armor RaggedLeahter = new Armor("Ragged leather armor", 1, 1, 1, 0);
            BackPack.Items.Add(RaggedLeahter);
        }

        // Methods

        public void TakeDamage(int damage) => Health -= damage;

        public void TakeHealing(int heal) => Health += heal;

        public void AddGold(int gold) => Gold += gold;

        public void RemoveGold(int gold) => Gold -= gold;
        public void SetName()
        {
            Name = Game.AskHeroName();
        }
    }
}

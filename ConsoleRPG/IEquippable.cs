using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal interface IEquippable
    {
        void Equip(Hero hero);
        void Unequip(Hero hero);
    }
}

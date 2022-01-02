using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item // inheritance, weapon is child of item
    {
        // Item, name, namePlural from item
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        // constructor
        //  derived classes are passing the required values to the base class
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}

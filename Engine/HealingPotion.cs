using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item // base class of item (inheritance). healing class now child of item
    {
        // ID, name, namePlural from Item class
        public int AmountToHeal { get; set; }

        // constructor
        // derived classes are passing the required values to the base class
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}

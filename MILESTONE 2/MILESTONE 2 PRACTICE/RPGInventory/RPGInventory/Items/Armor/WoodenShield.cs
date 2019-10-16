using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Armor
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = "Wooden Shield";
            Description = "More apt to giving you a splinter over protecting you.";
            Weight = 7;
            Type = ItemType.Armor;
        }
    }
}

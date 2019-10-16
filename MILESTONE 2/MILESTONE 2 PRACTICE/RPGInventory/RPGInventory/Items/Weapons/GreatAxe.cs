using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Weapons
{
    public class GreatAxe : Item    
    {
        public GreatAxe()
        {
            Name = "Great Axe";
            Description = "A mighty axe that requires two hands to use.";
            Weight = 6;
            Type = ItemType.Weapon;
        }
    }
}

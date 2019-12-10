using NPC_rpg.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_rpg.Creature.Hero
{
    class Bag : IBag
    {
        private readonly int maxItems = 5;
        private int currentItems;
        List<IItems> items;
        public Bag()
        {
            items = new List<IItems>();
            currentItems = 0;
        }
    }
}

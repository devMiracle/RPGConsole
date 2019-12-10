using NPC_rpg.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_rpg.Creature.Hero
{
    class Hero : ICreature
    {
        private int coord_x;
        private int coord_y;
        private Bag bag;
        public readonly string nickname;

        public Hero(string nickname, IBag bag, int coord_x, int coord_y)
        {
            this.nickname = nickname;
            this.bag = (Bag)bag;
            this.coord_x = coord_x;
            this.coord_y = coord_y;
        }

    }
}

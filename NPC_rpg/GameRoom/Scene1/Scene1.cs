using NPC_rpg.Creature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_rpg.GameRoom.Scene1
{
    class Scene1 : IScene
    {
        List<ICreature> creatures;



        public Scene1(List<ICreature> creatures)
        {
            this.creatures = creatures;
        }
    }
}

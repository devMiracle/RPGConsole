using NPC_rpg.Creature;
using NPC_rpg.Creature.Hero;
using NPC_rpg.GameRoom.Scene1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPC_rpg.Print;

namespace NPC_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICreature> creatures = new List<ICreature>();
            creatures.Add(new Hero("Mira", new Bag(), 5, 5));
            Scene1 scene1 = new Scene1(creatures);
        }
    }
}

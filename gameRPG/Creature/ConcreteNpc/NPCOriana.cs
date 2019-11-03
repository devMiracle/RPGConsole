using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRPG.Creature.ConcreteNpc
{
    sealed class NPCOriana : ANpc
    {
        public NPCOriana(int x, int y)
        {
            name = "Oriana";
            xCoord = x;
            yCoord = y;
        }

        public override void TakeQuest()
        {
            Console.WriteLine("Sorry. Not quest from you now.");
        }

        public override void Talk()
        {
            Console.WriteLine($"Hello, My name is {name}");
        }
    }
}

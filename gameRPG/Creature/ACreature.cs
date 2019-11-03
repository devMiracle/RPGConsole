using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRPG.Creature
{
    abstract class ACreature : ICreature
    {
        public string name;
        protected int xCoord;
        protected int yCoord;
        public ACreature()
        {
            name = "n/a";
            xCoord = 0;
            yCoord = 0;
        }
        private int myVar;

        public int XCoord
        {
            get { return xCoord; }
        }
        public int YCoord
        {
            get { return yCoord; }
        }

    }
}

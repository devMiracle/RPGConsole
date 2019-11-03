using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRPG.Creature
{
    abstract class ANpc : ACreature
    {
        public abstract void TakeQuest();
        public abstract void Talk();
        
    }
}

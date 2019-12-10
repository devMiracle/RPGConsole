using NPC_rpg.GameRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_rpg.Print
{
    class Print
    {
        List<IPrint> prints;
        public Print(List<IPrint> prints)
        {
            this.prints = prints;
        }
        public void PrintAll()
        {
            foreach (var item in prints)
            {
                item.Print();//TODO : add downcast
            }
        }
        
    }
}

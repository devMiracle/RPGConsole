using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRPG.Creature
{
    class Hero : ActiveCreature
    {
        protected int coinOfLuck;
        protected int charLevel;
        protected int attackDamage;
        public Hero(string name)
        {
            this.name = name;
            coinOfLuck = 0;
            charLevel = 1;
            attackDamage = 2 * charLevel;
        }
        protected override void Attack()
        {
            //TODO: Add event
            if (target != null)
            {
                int distanceX = xCoord - target.XCoord;
                int distanceY = yCoord - target.YCoord;
                if ((-2 <= distanceX && distanceX <= 2) && (-2 <= distanceY && distanceY <= 2))
                {
                    target.TakeDamage(attackDamage);
                    Console.WriteLine($"Attack: {target.name}");
                }
                else
                    Console.WriteLine("Вы слишком далеко от цели.");
            }
            else
                Console.WriteLine("Нет таргета!");
        }
        protected override void Die()
        {
            Console.WriteLine("Вы Погибли.");
        }
        protected override void Drop()
        {
            Console.WriteLine("Что-то дропнули.");
        }
    }
}

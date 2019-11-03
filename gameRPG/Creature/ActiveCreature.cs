using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRPG.Creature
{
    abstract class ActiveCreature : ACreature
    {
        public int health;
        protected ActiveCreature target;
        public ActiveCreature()
        {
            health = 100;
            target = null;
        }
        protected virtual void SetTarget(ActiveCreature target)
        {
            this.target = target;
        }
        protected virtual void DropTarget()
        {
            target = null;
        }
        protected abstract void Attack();
        protected abstract void Die();
        protected abstract void Drop();
        public virtual void TakeDamage(int damage)
        {
            if (health > damage)
                health -= damage;
            else if (health <= damage)
                Die();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSlum;
using TheSlum.Interfaces;

namespace TheSlum
{
    public abstract class ActingCharacter : Character
    {
        protected ActingCharacter(string id, int x, int y, Team team, int healthPoints, int defensePoints, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range) 
        {
        }

        public override Character GetTarget(IEnumerable<Character> targetsList) 
        {
            Character foundTarget = null;
            foreach (var target in targetsList)
            {
                if (this.Team != target.Team && target.IsAlive)
                {
                    double distance = getDistance(this.X, this.Y, target.X, target.Y);

                    if (distance <= this.Range)
                    {
                        foundTarget = target;
                        break;
                    }
                }
            }

            return foundTarget;
        }

        public override void AddToInventory(Item item) 
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item) 
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected static double getDistance(int attackerX, int attackerY, int targetX, int targetY)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) + 
                (attackerY - targetY) * (attackerY - targetY));

            return distance;
        }        
    }
}

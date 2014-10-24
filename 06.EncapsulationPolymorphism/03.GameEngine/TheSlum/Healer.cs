using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSlum;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum
{
    public class Healer : ActingCharacter, IHeal
    {
        public Healer(string id, int x, int y, Team team, int healthPoints = 75, int defensePoints = 50, int range = 6)
            : base(id, x, y, team, healthPoints, defensePoints, range)
        {
            this.HealingPoints = 60;
            //// Health points of 75, Defense points of 50, Healing points of 60 and Range of 6           
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {  

            var canBeHeal = targetsList.Where(character =>
                character.Team == this.Team &&
                character.IsAlive &&
                this.Id != character.Id &&
                getDistance(this.X, this.Y, character.X, character.Y) <= this.Range
                );

            return canBeHeal.Min();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Heal: {0}", this.HealingPoints);
        }
    }
}

using System;

namespace TheSlum
{
    using TheSlum.Interfaces;

    public class Mage : ActingCharacter, IAttack
    {

        public Mage(string id, int x, int y, Team team, int healthPoints = 150, int defensePoints = 50, int range = 5)
            : base(id, x, y, team, healthPoints, defensePoints, range)
        {
            this.AttackPoints = 300;
            //// Health points of 150, Defense points of 50, Attack points of 300 and Range of 5.            
        }

        public int AttackPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Attack: {0}", this.AttackPoints) ;
        }
    }
}

namespace TheSlum
{
    using TheSlum.Interfaces;

    public class Warrior : ActingCharacter, IAttack
    {
        public Warrior(string id, int x, int y, Team team, int healthPoints = 200, int defensePoints = 100, int range = 2)
            : base(id, x, y, team, healthPoints, defensePoints, range)
        {
            this.AttackPoints = 150;
            //// Health points of 200, Defense points of 100, Attack points of 150 and Range of 2.
        }
        
        public int AttackPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Attack: {0}", this.AttackPoints);
        }
    }
}
 
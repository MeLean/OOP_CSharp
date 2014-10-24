using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSlum;

namespace _03.GameEngine.TheSlum
{
    class Injection : Bonus
    {
        public Injection(string id, int healthEffect, int defenseEffect, int attackEffect) 
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = true;
        }
    }
}

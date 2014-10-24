using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSlum;

namespace _03.GameEngine.TheSlum
{
    class Pill : Bonus
    {
        public Pill(string id, int healthEffect, int defenseEffect, int attackEffect) 
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Countdown = 1;
            this.Timeout = 1;
            this.HasTimedOut = true;
        }
    }
}

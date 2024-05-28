using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Ninja : Hero
    {

        private double Strikes = 0;
        public Ninja(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }


        public override double Attack()
        {

            double damage  =  base.Attack();
            int attackBoost = 0;

            switch (Strikes)
            {
                case 0: attackBoost += 1;
                    break;
                case 1: attackBoost += 5;
                    break;
                case 2: attackBoost += 10;
                    break;
                case 3: { attackBoost = 0; Strikes = -1; };
                    break;
            } 
            Strikes++;
            return damage+attackBoost; 
        }

    }
}

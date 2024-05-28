using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Reaper : Hero
    {
        public Reaper(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        

        public override double Defend(double damage)
        {
          double probability = random.NextDouble();
            if(probability < 0.4)
            {
                return (base.Defend(damage-(0.35*damage))) ;
            }

            return base.Defend(damage);
        }
    }
}

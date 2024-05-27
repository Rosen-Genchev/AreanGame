using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Axe : IWeapon
    {
        private int Strikes = 0;
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Axe(string name)
        {
            Name = name;
            AttackDamage = 17.5;
            BlockingPower = 10;

        }

        public void DoubleAttack(Hero Owner)
        {
            Strikes++;
            if (Strikes == 3)
            {
                Strikes = 0;
                AttackDamage += 0.2 * AttackDamage;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    internal class Sais : IWeapon 
    {
        
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeStealValue { get; private set; }

        private int Strikes = 0;   

        public Sais(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 10;

        }

        public void SpecialAbility()
        {
            AttackDamage = 10;
            BlockingPower = 10;
            Strikes++;
            if(Strikes == 2)
            {
                AttackDamage *= 3;
                BlockingPower *= 3;
            }
           
        }
    }
}

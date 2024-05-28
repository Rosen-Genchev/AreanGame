using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Scyte : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeStealValue {  get; private set; }

        public Scyte(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }

        public void SpecialAbility()
        {
            LifeStealValue = 0.5 * AttackDamage;
        }
    }
}

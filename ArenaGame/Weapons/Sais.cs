﻿using System;
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

        public Sais(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 5;

        }

        public void UltimateAttack(Hero Owner,Hero Defender)
        {
            if (Defender.Defend(Owner.Attack()) == 0)
            {
                AttackDamage *= 3;
            }
        }
    }
}

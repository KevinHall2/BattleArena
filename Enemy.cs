﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BattleArena
{
    internal class Enemy : Character
    {



        public Enemy()
        {
            Name = "6-Headed Hydra";
            MaxHealth = 20;
            AttackPower = 12;
            DefensePower = 6;
            HeadsRemaining = 6;
        }


      



        public override float Attack(Character other)
        {
            
            Console.WriteLine("The Hydra assails you with its heads.");
            float damage = MathF.Max(0, AttackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public override void Die()
        {
            if (HeadsRemaining == 6)
            {
              Console.WriteLine("You sever two of the six heads. Four remain.");
            }
            else if (HeadsRemaining == 4)
            {
                Console.WriteLine("You sever two of the four heads. Two remain.");
            }
            else if (HeadsRemaining == 2)
            {
                Console.WriteLine("You sever the last two heads, slaying the beast");
            }
            
        }
    }
}

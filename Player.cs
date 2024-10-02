using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Player : Character
    {
        public Player()
        {
            Name = "You";
            MaxHealth = 40;
            Health = 40;
            AttackPower = 15;
            DefensePower = 5;
        }


         

         public override float Attack(Character other)
        {   
            Console.WriteLine("You hack and slash at the Hydra's heads.");
            return base.Attack(other);
            
        }

        public override void Die()
        {
            Console.WriteLine("The hydra rips you limb from limb with its heads. You are dead.");
        }
    }
}

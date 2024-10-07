using System;
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
            Health = 20;
            AttackPower = 15;
            DefensePower = 6;
            //the hydra starts with 6 heads
            HeadsRemaining = 6;
        }


      



        public override float Attack(Character other)
        {           
            Console.WriteLine("The Hydra assails you with its heads.");
            float damage = MathF.Max(0, AttackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public override void TakeDamage(float damage)
        {
            Health -= damage;
            Console.WriteLine("You dealt " + damage + " damage.");
            Console.WriteLine("<<Press any key to continue.>>");
            Console.ReadKey();
            Console.Clear();
            if (Health == 0)
            {
                Die();
            }
        }

        public override void Die()
        {
            if (HeadsRemaining == 6)
            {
              Console.WriteLine("You sever two of the six heads. Four remain.");
                SeverHeads();
            }
            else if (HeadsRemaining == 4)
            {
                Console.WriteLine("You sever two of the four heads. Two remain.");
                SeverHeads();
            }
            else if (HeadsRemaining == 2)
            {
                Console.WriteLine("You sever the last two heads, slaying the beast");
            }
        }

        //the enemy health doesn't need to be reset since its array indexes are created in the Start function of Game
        public override void ResetHealth()
        {
            throw new NotImplementedException();
        }


        //function for removing hydra heads
        public void SeverHeads()
        {
            HeadsRemaining -= 2;
            AttackPower -= 2;
        }
    }
}

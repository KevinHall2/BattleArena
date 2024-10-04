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
            //player doesn't have an updated RemaniningHead variable since the player won't interact with that the same way the Hydra will
            Name = "You";
            MaxHealth = 40;
            Health = 40;
            AttackPower = 15;
            DefensePower = 7;
        }


        public override float Attack(Character other)
        {
            Console.WriteLine("You slash at the Hydra's heads.");
            float damage = MathF.Max(0, AttackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }
        public override void Die()
        {
            Console.WriteLine("The Hydra rips you apart with its heads. You have been slain.");
            Console.WriteLine("<<Press any key to continue.>>");
            Console.ReadKey();
            Console.Clear();
        }

        public override void TakeDamage(float damage)
        {
            Health -= damage;
            Console.WriteLine("The Hydra deals " + damage + " damage to you.");
            Console.WriteLine("<<Press any key to continue.>>");
            Console.ReadKey();
            Console.Clear();
            if (Health == 0)
            {
                Die();
            }
        }

        public override void Heal(float health)
        {
            Console.WriteLine("You channel your divinity and regain " + health + " health.");
            base.Heal(health);
            Console.WriteLine("<<Press any key to continue.>>");
            Console.ReadKey();
            Console.Clear();
        }

        public override void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
}

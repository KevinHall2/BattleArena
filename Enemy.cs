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

        private string _name;
        private float _maxHealth;
        private float _health;
        private float _attackPower;
        private float _defensePower;
        private float _headsRemaining;

        public Enemy()
        {
            _name = "6-Headed Hydra";
            _maxHealth = 20;
            _attackPower = 12;
            _defensePower = 6;
            _headsRemaining = 6;
        }

        public float HeadsRemaining
        {
            get => _headsRemaining;
        }
      



        public override float Attack(Character other)
        {
            
            Console.WriteLine("The Hydra assails you with its heads.");
            float damage = MathF.Max(0, _attackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public override void Die()
        {
            if (HeadsRemaining == 6)
            {
              Console.WriteLine("You sever two of the six heads. Four remain.");
                _attackPower -= 2;
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

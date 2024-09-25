using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BattleArena
{
    internal abstract class Enemy : Character
    {

        private string _name;
        private float _maxHealth;
        private float _health;
        private float _attackPower;
        private float _defensePower;

        public Enemy()
        {
            _name = "Hydra";
            _maxHealth = 20;
            _attackPower = 12;
            _defensePower = 6;
        }

      



        public override float Attack(Character other)
        {
            
            Console.WriteLine("The Hydra assails you with its six heads.");
            float damage = MathF.Max(0, _attackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public override void Die()
        {
            Console.WriteLine("You sever two of the six heads. Four remain.");
        }
    }
}

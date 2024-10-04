using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal abstract class Character
    {
        private string _name = "Character";

        private float _maxHealth = 10;

        private float _health = 10;

        private float _attackPower = 1;

        private float _defensePower = 1;

        //variable and property that will be used to determine the hydra's power level; it decreases as the amount of heads decreases
        private float _headsRemaining = 1;


        public string Name
        {
            get => _name;
            protected set => _name = value;
        }

        public float MaxHealth
        {
            get => _maxHealth;
            protected set => _maxHealth = value;
        }

        public float Health
        {
            get => _health;
            protected set
            {
                _health = Math.Clamp(value, 0, _maxHealth);
            }
        }

        public float AttackPower
        {
            get => _attackPower;
            protected set => _attackPower = value;
        }

        public float DefensePower
        {
            get => _defensePower;
            protected set => _defensePower = value;
        }

        //variable and property that will be used to determine the hydra's power level; it decreases as the amount of heads decreases
        public float HeadsRemaining
        {
            get => _headsRemaining;
            protected set => _headsRemaining = value;
        }

        public Character(string name,
            float maxHealth,
            float attackPower,
            float defensePower)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }

        public Character() { }



        public virtual float Attack(Character other)
        {
            float damage = MathF.Max(0, _attackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public virtual void TakeDamage(float damage)
        {
            _health -= damage;
            if (Health == 0)
            {
                Die();
            }
        }

        public virtual void Heal(float health)
        {
            Health += health;
        }

        public abstract void Die();
    }
}

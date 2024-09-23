﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Character
    {
        private string _name = "Character";

        private float _maxHealth = 10;

        private float _health = 10;

        private float _attackPower = 1;

        private float _defensePower = 1;


        public string Name
        {
            get => _name;
        }

        public float MaxHealth
        {
            get => _maxHealth;
        }

        public float Health
        {
            get => _health;
            private set
            {
                _health = Math.Clamp(value, 0, _maxHealth);
            }
        }

        public float AttackPower
        {
            get => _attackPower;
        }

        public float DefensePower
        {
            get => _defensePower;
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

        public float Attack(Character other)
        {
            float damage = MathF.Max(0, _attackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public void TakeDamage(float damage)
        {
            _health -= damage;
            if (Health == 0)
            {
                Die();
            }
        }

        public void Heal(float health)
        {
            Health += health;
        }

        private void Die()
        {
            Console.WriteLine(Name + "has been slain.");
        }
    }
}

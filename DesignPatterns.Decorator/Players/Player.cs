using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Players
{
    // Clase concreta de la entidad default sin modificadores
    public class Player : IPlayer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public Player(Guid id, string name, int health, int attack, int defense)
        {
            Id = id;
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }
        public int GetRemainingHP() => Health;
        public void AttackPlayer(IPlayer enemy) => enemy.Defend(GetTotalDamage());

        public void Defend(int incomingAttack)
        {
            int statsDiff = incomingAttack - GetTotalDefense();
            int damageTaken = statsDiff < 0 ? 0 : statsDiff;
            var newHealth = Health - damageTaken;
            Health = newHealth < 0 ? 0 : newHealth;
            Console.WriteLine($"{Name}'s HP: {Health}");
        }

        public int GetTotalDamage() => Attack;

        public int GetTotalDefense() => Defense;
    }
}

using System;

namespace Project_CS
{
    public class Enemy : Person
    {
        PrintSlow slow = new PrintSlow();
        public void EnemyFoe()
        {
            Name = "Enemy";
            Accuracy = 0;
            Health = 0;
            Attack = 0;
            Mana = 0;
        }

        public void DoesHit(Guts guts, Enemy enemy)
        {
            Random rand = new Random();
            int hit = rand.Next(1, 100);
            if (enemy.Health > 0)
            {
                if (hit <= Accuracy)
                {
                    slow.PrintSlowly($"The {Name} hits you, dealing {Attack} damage!");
                    guts.Health -= Attack;
                    guts.IsHeroDead();
                    slow.PrintSlowly($"You have {guts.Health} HP left.");
                }
                else
                {
                    slow.PrintSlowly($"The {Name} misses!");
                }
            }
            else
            {
                IsEnemyDead();
            }
        }

        public void ThrowAttack(Guts guts)
        {
            if (this.Health > 0)
            {
                slow.PrintSlowly($"The {Name} attacks you, dealing {Attack} damage.");
                guts.Health -= Attack;
                slow.PrintSlowly($"You have {this.Health} HP left.");
            }
            else
            {
                IsEnemyDead();
            }
        }
        public void IsEnemyDead()
        {
            if (this.Health <= 0)
            {
                slow.PrintSlowly($"You have defeated the {Name}. Congrats!");
            }
        }
    }
}
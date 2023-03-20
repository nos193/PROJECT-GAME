using System;

namespace Project_CS
{
    public class EnemyMage : Enemy
    {
        PrintSlow slow = new PrintSlow();
        public new void EnemyFoe()
        {
            Name = "Mage";
            Accuracy = 65;
            Health = 85;
            Attack = 40;
            Mana = 30;
        }

        public void MageChoice(Guts guts)
        {
            Random random = new Random();
            int choice = random.Next(1, 3);
            if (Health > 0) 
            {
                if (choice == 1)
                {
                    slow.PrintSlowly($"The {Name} attacks you, dealing {Attack} damage.");
                    guts.Health -= Attack;
                    guts.IsHeroDead();
                    slow.PrintSlowly($"You have {guts.Health} HP left.");
                }
                else
                {
                    MageFireball(guts);
                }
            }
            else
            {
                IsEnemyDead();
            }
        }
        public void MageFireball(Guts guts)
        {
            if (this.Mana >= 20 && this.Health > 0)
            {
                slow.PrintSlowly($"The Mage casts a fireball at you, dealing {this.Attack * 2} damage.");
                guts.Health -= this.Attack * 2;
                guts.IsHeroDead();
                slow.PrintSlowly($"You have {guts.Health} HP left.");
                this.Mana -= 20;
            }
            else if (this.Mana < 20 && this.Health > 0)
            {
                slow.PrintSlowly("The Mage does not have enough mana to cast a fireball!");
            }
            else
            {
                slow.PrintSlowly($"The {Name} misses!");
            }
        }
    }
}
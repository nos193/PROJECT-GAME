using System;

namespace Project_CS
{
    public class EnemyGoblin : Enemy
    {
        PrintSlow slow = new PrintSlow();
        
        public new void EnemyFoe()
        {
            this.Name = "Goblin";
            this.Accuracy = 90;
            this.Health = 50;
            this.Attack = 25;
            this.Mana = 0;
        }
    }
}
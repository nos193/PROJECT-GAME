using System;

namespace Project_CS
{
    public class EnemyKnight : Enemy
    {
        public new void EnemyFoe()
        {
            this.Name = "Knight";
            this.Accuracy = 75;
            this.Health = 100;
            this.Attack = 80;
            this.Mana = 0;
        }
        
    }
}
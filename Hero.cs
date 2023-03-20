using System;

namespace Project_CS
{
    public class Guts : Person
    {
        PrintSlow slow = new PrintSlow();
        public new void Hero()
        {
            this.Name = "Guts";
            this.Accuracy = 90;
            this.Health = 200;
            this.Attack = 70;
            this.Mana = 50;
        }

        public void DisplayHeroStats()
        {
            slow.PrintSlowly("          -------------------------");
            slow.PrintSlowly($"           {Name}");
            slow.PrintSlowly($"           Health: {Health}");
            slow.PrintSlowly($"           Attack: {Attack}");
            slow.PrintSlowly($"           Mana: {Mana}");
            slow.PrintSlowly("          -------------------------");
        }

        public void DoesItHit(Enemy enemy)
        {
            Random rand = new Random();
            int hit = rand.Next(1, 100);
            if (hit <= Accuracy)
            {                
                Console.WriteLine(@"
⢤⣴⣿⠿⣻⣯⡿⣫⣾⣖⢦⣾⣿⠇⣇⣿⣿⣿⣷⣿⣿⣿⣿⣾⣿⣿⣿⣷⣾⣿⣿⣿⣿⣯⣿⡝⢿⣮⣿⣷⡈⠻⣏⠀⠀⠀⢻⠀⠀⠀⠀⢸⣿⣿⣷⣶⣯⣽⣿⣿⣿⣿⡟⠛⡇
⣴⣿⣽⣿⣿⣟⣵⣿⣿⣼⣿⣿⣿⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠹⣿⣯⣿⣦⡉⠹⣿⣏⠀⠈⠙⠚⠃⠹⣦⡀⠀⠀⢸⡉⢿⣿⠙⠛⢿⣏⠉⠛⢿⡷⠀⠁
⣿⡿⣋⣩⣷⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠘⣿⣿⣿⣿⢹⣿⣿⣯⢿⣿⣿⣿⣿⣿⣧⢻⣿⣿⣿⣿⣄⣿⣿⣷⡀⠀⠀⠻⠿⢯⣿⠀⠀⢸⣇⠉⢻⠀⠀⠀⢙⠆⠀⠀⠱⠀⠀
⢻⣿⣿⡯⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢰⣿⣿⡇⠹⣸⣿⣿⣿⠏⢻⣿⣿⡟⣿⡈⢿⣿⢿⣿⣿⣿⣾⣿⡏⠉⠀⠀⠀⠲⢤⣿⡆⢶⠀⣿⡄⠀⠀⠀⠀⠈⠇⠀⠀⠀⠀⠀
⣿⣻⣽⣾⣿⣿⣿⣿⣹⣿⣿⡿⣿⣿⣿⣿⣿⣸⣿⣿⣷⣄⣿⣿⡇⢿⣦⠀⣿⣿⡃⢙⣿⣻⣿⠀⠙⠦⣍⡻⣿⣷⡀⠀⠀⠀⠀⠀⢻⣅⡈⠙⢹⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡟⣴⣶⠋⣿⣿⣿⣯⣿⣿⣿⣇⡇⣿⣿⣿⣿⣿⣿⣯⣿⣿⣿⠈⣧⠀⣿⣧⡗⢸⡇⠀⠈⢿⣿⠀⠀⠀⠈⠉⠺⢿⠃⠀⠀⠀⠀⠀⠀⠙⢿⣽⡿⣷⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣽⢛⠏⢠⣿⣴⣿⣿⡟⡇⡟⣿⣇⣿⣿⢻⣿⣿⣿⡟⠚⢿⣿⡄⠈⢧⡸⣿⡇⢸⠁⠀⠀⠈⣿⠀⠀⢠⠄⠀⠀⠘⠃⠀⠀⠀⡀⠀⠀⠀⠀⠈⣿⣶⡓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣧⣰⣰⣿⣿⣿⡿⣿⣇⢹⣧⣿⣿⣽⣿⡃⠻⡌⠻⢧⣀⣼⣿⣷⠀⠀⠳⣿⠁⠀⠀⠀⠀⠀⠸⠀⢀⡇⠀⠀⠀⠀⠀⠀⣀⡞⠀⠀⠀⠀⠀⠀⠀⢙⣷⣅⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣯⠛⢣⡟⣹⢃⡇⢹⣏⡎⣿⣿⣏⠻⣿⣧⠀⠇⢀⣾⣿⣟⡿⠻⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⢀⣼⠁⠀⠀⠀⠀⠀⣴⠿⠀⠀⠀⠀⠀⠀⠀⠀⣀⢙⡝⢦⡀⠀⠀⠀⠀⠀⠀⠀
⠈⠅⣼⣿⣿⢸⣇⠘⣿⣿⣿⣿⣿⣆⠈⠻⣷⣔⣸⣿⣿⡿⠀⠀⠀⠀⠀⢀⡄⠀⠀⠀⠀⠀⡴⣿⡟⠀⠀⠀⠀⠀⣰⠿⠼⠔⠀⠀⠀⣀⣤⣶⣷⣽⠎⠀⠘⢷⡀⠀⠀⠀⠀⠀⠀
⣤⣰⣿⢋⣿⣿⣿⣦⣿⣿⣿⣿⡌⢻⣄⠀⠀⢹⣿⣿⣿⠀⠀⠀⠀⢀⣰⣿⢃⢸⠀⠀⠀⣸⠃⣽⡇⠁⢀⣀⣠⠞⠁⠀⠀⠀⠘⢢⠞⠉⠁⠈⠇⣯⣷⢠⠀⠸⣳⠀⠀⠀⠀⠀⠀
⢂⠉⡟⣹⣿⣿⣻⣿⣿⣿⣿⣿⣿⡄⠈⠃⣠⣿⣿⣿⡿⠀⠀⠀⣰⣿⡟⣿⢸⣸⠃⠀⠀⠁⠀⠁⠀⢀⡼⠋⠁⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠋⠀⠀⢘⣧⠀⠀⠀⠀⠀
⡈⢄⣼⣿⢿⢻⣿⣿⣿⣿⣿⣿⡿⣿⣀⣰⣿⣟⣿⡿⠁⠀⢀⣾⣽⠟⠀⢿⠞⠇⠀⠀⠀⠀⠀⠀⢠⠏⠀⠀⠀⠀⠀⢲⣶⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣧⠀⠀⠀⠀
⣿⠺⠉⠀⢸⣎⣿⣾⣾⣻⣿⣿⣟⣾⡙⣿⣿⣿⣿⠁⣀⣤⣞⣼⣏⠀⢠⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣄⠀⠀⠀
⢿⡀⠂⣠⣼⣿⡜⢿⡝⠉⣉⣭⣿⣿⣤⢼⣿⣿⣿⠾⠋⠈⣿⡿⣿⣦⣏⡔⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣄⢠⣿⣿⣦⣤⣤⢤⡄⠀⠀⠀⠀⠀⠀⠀⣿⢿⣿⡧⠀⠀
⣤⢾⣯⣷⣿⣿⣿⡾⣶⣿⣥⠖⠋⠙⣿⣶⣭⣭⡋⠀⠀⠀⠈⠀⠈⢉⣻⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠸⠛⢿⣿⣿⠛⡄⠀⠀⠀⠀⠀⠀⢸⣿⣿⡧⠹⠀⣤
⣺⡉⣿⣑⡃⣿⣿⣷⢿⣿⡇⠀⠀⠀⠹⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠈⠉⠉⠛⢻⣦⠄⠀⠀⠀⠀⢸⢋⡿⣃⠀⢨⣿
⣯⣿⡫⠛⣻⡿⣷⣿⢸⣿⣷⡌⠀⠘⠀⢻⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⢷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣼⣀⣀⠀⠀⠠⣽⢀⡟⢁⡠⢸⡿
⢿⡛⣄⣺⣿⢿⣿⣿⣧⡙⠿⠥⢠⣄⣠⣾⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠏⠀⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠷⣿⡿⡇⠀⢰⡿⠈⣰⣿⣿⣿⢁
⡎⢿⣟⣼⣛⡫⣿⣿⣹⣿⣛⡿⠿⢿⡷⠟⠹⣯⣻⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠋⠀⢸⠉⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢀⡶⠞⠾⣇⣾⣿⣿⣿⠟⠆
⣿⡘⣿⠊⢃⣽⣿⡞⣻⣿⣿⣿⠉⠀⠀⠀⠀⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⢀⣶⠀⠀⠀⠀⢰⠏⠀⣠⠾⢰⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠀⠀⠀⣿⣿⣿⣿⣿⢈⠀
⣿⣧⠹⢰⣿⣿⢼⣧⣿⣿⣿⠟⠉⡉⠀⠀⠀⠸⣿⢿⣿⣿⣿⠀⠀⠀⠀⠀⠀⢀⡴⢋⣿⠀⠀⠀⢀⡏⠀⠀⡇⢀⡎⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⡇⠀
⣿⣿⣇⢹⣿⡿⣷⣻⡙⢾⣕⠨⣉⡻⠗⠀⠀⢠⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⣨⣾⣿⣿⣆⣀⣀⣸⣄⡀⠞⠀⡾⠀⢀⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣷⠀
⣿⣿⣿⡜⣿⣿⣿⣿⣟⢶⣟⣂⣁⣀⣀⣤⣤⣾⡿⠟⣿⣿⣽⣀⣀⣀⣠⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⣾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⣿⠟⠀
⣿⣿⣿⣿⣿⣟⢩⡭⣿⣿⣾⣯⣭⣭⢍⣿⣿⣿⣷⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⢰⣧⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣾⣥
⣿⣿⣿⣿⣿⡻⣷⡓⣩⣿⠟⠠⠀⣊⡽⢷⣟⣿⣿⣆⡼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⣨⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⡈⢷⠺⣿⣿⣀⠤⡖⠉⣹⣿⡿⣿⣿⡿⢿⣾⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣀⣠⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠛
⣿⣿⣿⣿⣿⣿⣿⣄⠀⣭⢿⡗⠀⣠⡼⢯⣤⣟⣻⠜⢿⠀⠘⣿⣧⢹⡎⠙⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾");
                slow.PrintSlowly("You hit!");
                GutsAttack(enemy);
            }
            else
            {
                slow.PrintSlowly("You missed!");
            }
        }
        
        public void IsHeroDead()
        {
            if (this.Health <= 0)
            {
                //Console.Clear();
                slow.PrintSlowly("You have 0 HP");
                slow.PrintSlowly("You have died.");
                Console.WriteLine(@"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⠀⠀⠀⢀⣴⣿⡶⠀⣾⣿⣿⡿⠟⠛⠁
⠀⠀⠀⠀⠀⠀⣀⣀⣄⣀⠀⠀⠀⠀⣶⣶⣦⠀⠀⠀⠀⣼⣿⣿⡇⠀⣠⣿⣿⣿⠇⣸⣿⣿⣧⣤⠀⠀⠀
⠀⠀⢀⣴⣾⣿⡿⠿⠿⠿⠇⠀⠀⣸⣿⣿⣿⡆⠀⠀⢰⣿⣿⣿⣷⣼⣿⣿⣿⡿⢀⣿⣿⡿⠟⠛⠁⠀⠀
⠀⣴⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⢠⣿⣿⣹⣿⣿⣿⣿⣿⣿⡏⢻⣿⣿⢿⣿⣿⠃⣼⣿⣯⣤⣴⣶⣿⡤⠀
⣼⣿⠏⠀⣀⣠⣤⣶⣾⣷⠄⣰⣿⣿⡿⠿⠻⣿⣯⣸⣿⡿⠀⠀⠀⠁⣾⣿⡏⢠⣿⣿⠿⠛⠋⠉⠀⠀⠀
⣿⣿⠲⢿⣿⣿⣿⣿⡿⠋⢰⣿⣿⠋⠀⠀⠀⢻⣿⣿⣿⠇⠀⠀⠀⠀⠙⠛⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀
⠹⢿⣷⣶⣿⣿⠿⠋⠀⠀⠈⠙⠃⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣴⣶⣦⣤⡀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⣠⡇⢰⣶⣶⣾⡿⠷⣿⣿⣿⡟⠛⣉⣿⣿⣿⠆
⠀⠀⠀⠀⠀⠀⢀⣤⣶⣿⣿⡎⣿⣿⣦⠀⠀⠀⢀⣤⣾⠟⢀⣿⣿⡟⣁⠀⠀⣸⣿⣿⣤⣾⣿⡿⠛⠁⠀
⠀⠀⠀⠀⣠⣾⣿⡿⠛⠉⢿⣦⠘⣿⣿⡆⠀⢠⣾⣿⠋⠀⣼⣿⣿⣿⠿⠷⢠⣿⣿⣿⠿⢻⣿⣧⠀⠀⠀
⠀⠀⠀⣴⣿⣿⠋⠀⠀⠀⢸⣿⣇⢹⣿⣷⣰⣿⣿⠃⠀⢠⣿⣿⢃⣀⣤⣤⣾⣿⡟⠀⠀⠀⢻⣿⣆⠀⠀
⠀⠀⠀⣿⣿⡇⠀⠀⢀⣴⣿⣿⡟⠀⣿⣿⣿⣿⠃⠀⠀⣾⣿⣿⡿⠿⠛⢛⣿⡟⠀⠀⠀⠀⠀⠻⠿⠀⠀
⠀⠀⠀⠹⣿⣿⣶⣾⣿⣿⣿⠟⠁⠀⠸⢿⣿⠇⠀⠀⠀⠛⠛⠁⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠈⠙⠛⠛⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
");
                Environment.Exit(0);
            }
        }

        public void ChooseAttack(Enemy enemy, Guts guts)
        {
            slow.PrintSlowly("Choose an attack :");
            slow.PrintSlowly("          --------------------");
            slow.PrintSlowly("           1. Normal attack");
            slow.PrintSlowly("           2. Special attack");
            slow.PrintSlowly("          --------------------");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    DoesItHit(enemy);
                    break;
                case "2":
                    SpecialAttack(enemy);
                    break;
                case "3":
                    LastChanceAttack(enemy, guts);
                    break;
                default:
                    slow.PrintSlowly("Invalid choice.");
                    ChooseAttack(enemy, guts);
                    break;
            }
        }
        public void GutsAttack(Enemy enemy)
        {
            enemy.Health -= this.Attack;
            slow.PrintSlowly($"You have dealt {this.Attack} damage to the {enemy.Name}.");
            if (enemy.Health <= 0) 
            {
                slow.PrintSlowly($"The {enemy.Name} has 0 HP left.");
            }
            else
            {
                slow.PrintSlowly($"The {enemy.Name} has {enemy.Health} HP left.");
            }
        }

        public void SpecialAttack(Enemy enemy)
        {
            if (this.Mana >= 20)
            {
                Console.WriteLine(@"
       ⢐⣿⣿⣿⣿⣿⡟⠉⠀⠀⣼⣿⢯⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⠹⣿⣿⣿⠀⠈⠉⢿⣿⣿⣿⣿⣿⡍⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢸⣏⢿⣿⣿⣿⣿⠇⠀⠀⢸⡿⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠻⣿⣇⠘⣿⣿⠀⢀⡀⢻⣿⣿⣿⣿⡿⢟⡇⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠸⣿⡄⢻⣿⣿⣿⠀⠀⠀⢸⡇⣾⠋⣿⣿⡿⢁⣿⣿⡟⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⢻⣿⣿⠀⠹⣿⡀⢻⣿⠴⠋⠀⢘⣿⣿⣿⣿⢷⣿⡇⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣿⣽⡄⢹⣿⣿⠀⠀⠀⠀⠧⡟⠀⣿⣿⠁⢸⣿⡏⠀⣿⡇⢻⣿⣿⣿⣿⣿⣿⡟⣿⡇⠀⢿⣿⠀⠀⢹⡧⣿⠁⠀⠀⠀⢨⣿⣿⣿⠃⣾⣽⣷⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⡟⢸⡿⣾⣿⣿⡇⠀⠀⠀⠀⢹⡀⠈⣏⠀⠸⣿⠀⠀⢸⠛⣿⣿⣿⣿⣿⣿⠿⣳⣿⠀⠀⣸⣿⠀⢀⣼⠇⠀⠀⠀⠀⠀⠰⣿⣿⣿⣼⡍⠃⣿⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣿⣌⢧⣸⣿⠿⢧⠀⠀⠀⣀⠀⠁⠀⢻⠀⠀⣿⢦⠘⠾⣇⠹⣿⣿⡟⢻⡿⢰⠏⡟⠀⣼⣿⣧⠞⠉⠁⣀⣠⣀⣀⠀⢀⣰⠟⢻⣿⣻⣇⣴⡟⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠘⢯⠻⢿⣿⡆⠘⢿⣾⣿⣿⣿⣶⣤⣀⣀⣀⠀⣀⣀⡀⠈⠀⠸⣿⡇⣸⣷⠏⠘⠁⣀⣉⣀⣀⣤⣴⣾⣿⣿⣿⣿⣿⠟⠁⠀⣸⢋⡟⢫⡞⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⢳⣾⣯⡁⠀⠀⠙⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣠⣿⡇⣿⣏⣤⣶⣾⣿⣿⣿⣿⣿⣿⣿⠿⠿⢿⣿⠁⠀⠀⠀⣿⣿⠇⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⢧⠈⣧⠀⠀⠀⠀⢻⣿⣿⣷⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢷⣿⣿⣿⣿⣿⣿⡟⠛⠉⠛⠛⠁⠀⣠⣿⠃⠀⠀⠀⠀⣿⡇⣼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⣿⡄⠀⠀⠀⠀⠻⣿⣻⣿⣿⡉⠉⢹⣿⣿⡿⠃⠘⠆⠀⠀⠸⠁⠈⠿⣿⣿⣶⣤⣤⣤⣴⣾⡿⠃⠀⠀⠀⠀⢠⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣧⠀⠀⠀⠀⠀⠈⠉⠛⠛⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⠀⠈⠉⠉⠀⠀⠀⠀⢠⡀⠀⠀⢸⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠸⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣧⠀⡀⣼⢸⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣀⣀⣀⣀⣠⣄⡀⠀⢸⡄⢻⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠓⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⠀⣰⠇⢸⣶⣶⣿⣿⣿⣿⣷⣦⣄⠀⠀⠀
⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⡇⠀⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠤⣤⡄⠀⠀⠀⠀⢀⣤⡤⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀⢀⢺⣶⠏⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⠀
⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡀⠈⢿⡄⠀⠀⢴⡶⠂⠀⠀⠀⠀⠀⢰⡋⠀⠀⠀⠀⠀⠀⢙⡆⠀⠀⠀⠀⠀⠀⢀⣼⠟⠀⠁⣸⡏⠀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣅⠀⠀⠻⣧⠀⠈⢿⣦⣄⠀⠀⠀⠀⠀⢻⣆⠀⠀⠀⠀⣰⡟⠁⠀⠀⠀⠀⣀⣴⠏⠀⠰⢆⣾⠟⠀⣀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣭⣆⠀⠀⠙⣧⡀⠈⢽⣿⣷⣤⣄⣀⣀⣈⣿⣷⣤⣴⣾⣟⣀⣀⣠⣤⣴⣾⣿⣣⠆⠀⢰⣾⣿⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣄⠘⣿⡆⠘⢻⣿⣷⣏⠛⢿⠛⣿⠉⢽⡏⠀⣿⠁⢿⢃⣿⣿⡿⣱⣯⣤⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⡿⣜⠿⣿⣾⣧⣼⣄⣰⣧⣠⣿⣴⣿⣿⣵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
                slow.PrintSlowly("You use your special attack!");
                enemy.Health -= this.Attack * 2;
                this.Mana -= 20;
                slow.PrintSlowly($"You have dealt {this.Attack * 2} damage to the enemy. Critical hit!");
                if (enemy.Health <= 0) 
                {
                    slow.PrintSlowly($"The {enemy.Name} has 0 HP left.");
                }
                else
                {
                    slow.PrintSlowly($"The {enemy.Name} has {enemy.Health} HP left.");
                }
            }
            else
            {
                slow.PrintSlowly("You do not have enough mana to use your special attack.");
            }
        }

        public void LastChanceAttack(Enemy enemy, Guts guts)
        {
            if (this.Health <= 30)
            {
                slow.PrintSlowly("You use your last chance attack!");
                enemy.Health -= this.Attack * 3;
                this.Accuracy -= 20;
                slow.PrintSlowly($"You have dealt {this.Attack * 3} damage to the enemy. Critical hit!");
                if (enemy.Health <= 0) 
                {
                    slow.PrintSlowly($"The {enemy.Name} has 0 HP left.");
                }
                else
                {
                    slow.PrintSlowly($"The {enemy.Name} has {enemy.Health} HP left.");
                }
            }
            else if (this.Health > 30)
            {
                slow.PrintSlowly("You do not have enough health left to use your last chance attack.");
                ChooseAttack(enemy, guts);
            }
        }
    }        
}

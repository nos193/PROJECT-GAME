using System;

namespace Project_CS
{
    public class LeftOrRight
    {
        public void InitializeGuts()
        {
            PrintSlow slow = new PrintSlow();
            slow.PrintSlowly("You are Guts, the Black Swordsman. You are on a quest to find the Behelit and save the world.");
            Guts guts = new Guts();
            Inventory inventory = new Inventory();
            guts.Hero();
            while (true)
            { 
                slow.PrintSlowly("You are in a castle with two doors. One is left, the other is right. Which one do you choose?");
                slow.PrintSlowly("You can type 'Status' to see your stats or type 'Item' to consumme an item.");
                string choice = Console.ReadLine();
                if (choice == "left" || choice == "Left")
                {
                    Console.Clear();
                    slow.PrintSlowly($"You have chosen the {choice} door.");
                    Random random = new Random();
                    int randomRoom = random.Next(0, 100);
                    if (randomRoom >= 0 && randomRoom < 25)
                    {
                        Loot();
                    }
                    if (randomRoom >= 25 && randomRoom <= 100)
                    {
                        slow.PrintSlowly("You stumbled upon an enemy!");
                        FightEnemies();
                    }

                }
                else if (choice == "right" || choice == "Right")
                {
                    Console.Clear();
                    slow.PrintSlowly($"You have chosen the {choice} door.");
                    Random random = new Random();
                    int randomRoom = random.Next(0, 100);
                    if (randomRoom >= 0 && randomRoom < 25)
                    {
                        Loot();
                    }
                    else if (randomRoom >= 25 && randomRoom <= 100)
                    {
                        slow.PrintSlowly("You stumbled upon an enemy!");
                        FightEnemies();
                    }
                }
                else if (choice == "Status" || choice == "status")
                {
                    Console.Clear();
                    guts.DisplayHeroStats();
                }
                else if (choice == "Item" || choice == "item")
                {
                    Console.Clear();
                    inventory.ChooseConsumable(guts);
                }
                else
                {
                    slow.PrintSlowly("Please choose a valid option.");
                    
                }

                void FightEnemies()
                {
                    Random random = new Random();
                    int randomEnemy = random.Next(0, 100);
                    if (randomEnemy >= 0 && randomEnemy <= 34)
                    {
                        slow.PrintSlowly("You have encountered a Goblin.");
                        EnemyGoblin goblin = new EnemyGoblin();
                        goblin.EnemyFoe();
                        while (goblin.Health > 0)
                        {
                            guts.ChooseAttack(goblin, guts);
                            goblin.DoesHit(guts, goblin);
                            guts.IsHeroDead();
                        }
                    }
                    else if (randomEnemy >= 35 && randomEnemy <= 67)
                    {
                        slow.PrintSlowly("You have encountered a Knight.");
                        EnemyKnight knight = new EnemyKnight();
                        knight.EnemyFoe();
                        while (knight.Health > 0)
                        {
                            guts.ChooseAttack(knight, guts);
                            knight.DoesHit(guts, knight);
                            guts.IsHeroDead();
                        }
                    }
                    else if (randomEnemy >= 68 && randomEnemy <= 100)
                    {
                        slow.PrintSlowly("You have encountered a Mage.");
                        EnemyMage mage = new EnemyMage();
                        mage.EnemyFoe();
                        while (mage.Health > 0)
                        {
                            guts.ChooseAttack(mage, guts);
                            mage.MageChoice(guts);
                            guts.IsHeroDead();
                        }
                    }
                }

                void Loot()
                {
                    Guts guts = new Guts();
                    guts.Hero();
                    slow.PrintSlowly("You have found a chest, how lucky!");
                    Random random = new Random();
                    int randomLoot = random.Next(0, 100);
                    if (randomLoot <= 50)
                    {
                        slow.PrintSlowly("You have found a health potion.");
                        inventory.HealthPotion += 1;
                    }
                    else if (randomLoot <= 75)
                    {
                        slow.PrintSlowly("You have found a mana potion.");
                        inventory.ManaPotion += 1;
                    }
                    else if (randomLoot <= 90)
                    {
                        slow.PrintSlowly("You have found a ring.");
                        inventory.Ring += 1;
                    }
                    else if (randomLoot <= 100)
                    {
                        slow.PrintSlowly("You have found a Behelit! Use it before it's too late!!");
                        inventory.Behelits += 1;
                    }
                }
            }
        }
    }
}
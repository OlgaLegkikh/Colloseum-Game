using System;

namespace Colloseum_Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Balabol balabol = new Balabol();
            //Приветствие
            Console.WriteLine($"Приветствую в Колизее глупцов! Как зовут тебя, {balabol.appealToUser()}?");
            string userName = Console.ReadLine();

            bool gameIsOn = true;

            while (gameIsOn)
            {

                var hero = HeroChoice();

                Enemy enemy = new Enemy();
                Console.WriteLine($"Ваш соперник {enemy.enemyName} со здоровьем {enemy.enemyHealth}! Да прибудет начнется бой!");
                
                while ((hero.Health > 0) && (enemy.enemyHealth > 0))
                {
                    Console.WriteLine($"{hero.Name}: {hero.Health}, {hero.Mana}       {enemy.enemyName}: {enemy.enemyHealth}");
                    var rnd = new Random();
                    Console.WriteLine("1 - атаковать, 2 - лечится, 3 - улучшить оружие, 0 - выйти");
                    string userChoice = Console.ReadLine();
                    
                    if (userChoice == "0")
                    {
                        Console.Clear();
                        Console.WriteLine($"До новых встреч, {userName}");
                        gameIsOn = false;
                        break;
                    }
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine(balabol.comment(rnd.Next(1,3)));
                            enemy.enemyHealth -= hero.Attack();
                             
                            break;
                        case "2":
                            Console.WriteLine(balabol.comment(rnd.Next(1, 3)));
                            hero.Heal();
                            break;
                        case "3":
                            Console.WriteLine(balabol.comment(rnd.Next(1, 3)));
                            hero.IncreaseDamage();
                            break;
                        default:
                            Console.WriteLine($"{hero.Name} не разобрал команду {userName}. Возможно это запомнят как решающий момент.");

                            break;
                    }
                    if (enemy.enemyHealth <= 0)
                    {
                        gameIsOn = GameSwitch("Вы выиграли бой! Хотите повторить?");

                    }
                    else if (hero.Health <= 0)
                    {
                        gameIsOn = GameSwitch("Вы проиграли бой! Возьмете реванш?");
                    }
                    else
                    {
                        Console.WriteLine("А теперь ход противника!");
                        hero.Health -= enemy.EnemyAttack();
                    }
                    Console.WriteLine(Environment.NewLine);

                }
            }

            Hero HeroChoice()
            {
                
                Console.WriteLine($"{Environment.NewLine}Кого отправишь на арену, {userName}?");
                var knight = new Knight();
                var warrior = new Warrior();
                var hunter = new Hunter();
                Console.WriteLine($"{Environment.NewLine}1 - {knight.Name}, 2 - {warrior.Name}, 3 - {hunter.Name}");
                string heroId = Console.ReadLine();

                switch (heroId)
                {
                    case "1":
                        Console.WriteLine($"{knight.Name} - отличный выбор!");
                        return knight;
                    case "2":
                        Console.WriteLine($"{warrior.Name} - шикарный выбор!");
                        return warrior;
                    case "3":
                        Console.WriteLine($"{hunter.Name} - прекрасный выбор!");
                        return hunter;
                    default:
                    Console.WriteLine($"Среди нас таких нет");
                        return HeroChoice();

                }

            }


            bool GameSwitch(string switchPhrase)
            {
                Console.WriteLine(switchPhrase);
                Console.WriteLine("1 - да, 2 - нет");
                string userChoice = Console.ReadLine();
                if(userChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Отлично! Продолжаем!");
                    return true;
                }
                else if (userChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("До новых встреч!");
                    return false;
                }
                else
                {
                    return GameSwitch($"Я не знаю такую команду.\n {switchPhrase}");
                }
            }
            
        }
    }
}

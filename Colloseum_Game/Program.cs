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
                Console.WriteLine($"Ваш соперник {enemy.enemyName} со здоровьем {enemy.enemyHealth}! Да прибудет с вам сила");
                
                while ((hero.Health > 0) && (enemy.enemyHealth > 0))
                {
                    var rnd = new Random();
                    Console.WriteLine("1 - атаковать, 2 - лечится, 3 - улучшить оружие, 0 - выйти");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    
                    if (userChoice == 0)
                    {
                        Console.WriteLine($"До новых встреч {userName}");
                        gameIsOn = false;
                        break;
                    }
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine(balabol.comment(rnd.Next(1,3)));
                            enemy.enemyHealth -= hero.Attack();
                             
                            break;
                        case 2:
                            Console.WriteLine(balabol.comment(rnd.Next(1, 3)));
                            hero.Heal();
                            break;
                        case 3:
                            Console.WriteLine(balabol.comment(rnd.Next(1, 3)));
                            hero.IncreaseDamage();
                            break;
                        default:
                            Console.WriteLine($"Мне не известна такая команда, {userName}");

                            break;
                    }
                    if (enemy.enemyHealth <= 0)
                    {
                        Console.WriteLine("Вы выиграли бой!");

                    }
                    else if (hero.Health <= 0)
                    {
                        Console.WriteLine("Вы проиграли бой!");
                    }
                    else
                    {
                        Console.WriteLine("А теперь ход противника!");
                        hero.Health -= enemy.EnemyAttack();
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine($"Knight stats: {hero.Health}, {hero.Mana}");
                    Console.WriteLine($"Enemy stats: {enemy.enemyHealth}{Environment.NewLine}");

                }
            }

            Hero HeroChoice()
            {
                Console.WriteLine($"Кого из своих подданых отправишь на арену, {userName}?");
                var knight = new Knight();
                var warrior = new Warrior();
                var hunter = new Hunter();
                Console.WriteLine($"1 - {knight.Name}, 2 - {warrior.Name}, 3 - {hunter.Name}");
                int heroId = Convert.ToInt32(Console.ReadLine());
                switch (heroId)
                {
                    case 1:
                        return knight;
                    case 2:
                        return warrior;
                    case 3:
                        return hunter;
                    default:
                    Console.WriteLine($"Среди нас таких нет, {userName}");
                        return HeroChoice();

                }
            }
        }
    }
}

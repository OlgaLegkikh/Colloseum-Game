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
            // TODO Создание персонажа
            
            Console.WriteLine($"Кого из своих подданых отправишь на арену, {userName}?");

            var knight = new Knight();
             Console.WriteLine($"1 - {knight.Name}, 2 - воин горизонта, 3 - северный охотник");
            int characterId = Convert.ToInt32(Console.ReadLine());



                Enemy enemy = new Enemy();
                Console.WriteLine($"Ваш соперник {enemy.enemyName} со здоровьем {enemy.enemyHealth}! Да прибудет с вам сила");
                while ((knight.Health > 0) && (enemy.enemyHealth > 0))
                {
                    Console.WriteLine("1 - атаковать, 2 - лечится, 3 - улучшить оружие, 0 - выйти");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    var rnd = new Random();
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
                            enemy.enemyHealth -= knight.Attack();
                             
                            break;
                        case 2:
                            Console.WriteLine(balabol.comment(rnd.Next(1, 3)));
                            knight.Heal();
                            break;
                        case 3:
                            Console.WriteLine(balabol.comment(rnd.Next(1, 3)));
                            knight.IncreaseDamage();
                            break;
                        default:
                            Console.WriteLine($"Мне не известна такая команда, {userName}");

                            break;
                    }
                    if (enemy.enemyHealth <= 0)
                    {
                        Console.WriteLine("Вы выиграли бой!");

                    }
                    else if (knight.Health <= 0)
                    {
                        Console.WriteLine("Вы проиграли бой!");
                    }
                    else
                    {
                        Console.WriteLine("А теперь ход противника!");
                        knight.Health -= enemy.enemyAttack();
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine($"Knight stats: {knight.Health}, {knight.Mana}");
                    Console.WriteLine($"Enemy stats: {enemy.enemyHealth}{Environment.NewLine}");

                }
            }
   
            
        }
    }
}

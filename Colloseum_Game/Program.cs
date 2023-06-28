using System;

namespace Colloseum_Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Приветствие
            Console.WriteLine("Приветствуем нового героя в Колизее! Как зовут тебя, храбрейший?");
            string userName = Console.ReadLine();

            bool gameIsOn = true;
            while (gameIsOn)
            { 
            //Создание персонажа
            
            Console.WriteLine($"Кого из своих подданых отправишь на арену, {userName}?");
            
            Console.WriteLine("1 - рыцарь пустоши, 2 - воин горизонта, 3 - северный охотник");
            int characterId = Convert.ToInt32(Console.ReadLine());
     
                    var weapon = new Weapon();
                    var knight = new Knight(weapon.damageS, weapon.damageF);
            
            Console.WriteLine("Какое оружие дашь ему в руки?");

            //Описание каждого из видов оружия. Прочитать выбор игрока. Запомнить выбор
            int weaponId = Convert.ToInt32(Console.ReadLine());


                Enemy enemy = new Enemy();
                Console.WriteLine($"Ваш соперник {enemy.enemyName} со здоровьем {enemy.enemyHealth}! Да прибудет с вам сила");
                while ((knight.Health > 0) && (enemy.enemyHealth > 0))
                {
                    Console.WriteLine("1 - атаковать, 2 - лечится, 3 - улучшить оружие");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Отличный выбор!");
                            enemy.enemyHealth -= knight.Attack();
                            break;
                        case 2:
                            Console.WriteLine("Как скажите!");
                            knight.Heal();
                            break;
                        case 3:
                            Console.WriteLine("И так тоже можно");
                            knight.IncreaseDamage();
                            break;
                        default:
                            Console.WriteLine("Так я еще не умею!");

                            break;
                    }
                    if (enemy.enemyHealth <= 0)
                    {
                        Console.WriteLine("Вы выиграли!");

                    }
                    else
                    {
                        Console.WriteLine("А теперь ход противника!");
                        knight.Health -= enemy.enemyAttack();
                    }
                    Console.WriteLine($"Knight stats: {knight.Health}, {knight.Mana}");
                    Console.WriteLine($"Enemy stats: {enemy.enemyHealth}");

                //        //Дать подарочек
                //        //Красиво Завершить бой
                }
            }
                  
                //Повторить 3 боя
            //Механика арены с боссом - счетчик для увелечения урона сбрасывается
                //Выбрать босса
                //Частично восстановить здоровье и ману игрока
                //Бой

                    //Выбор действия игрока (Атака, Лечение, Увеличение урона)
                    //Атака Босса
                    //Повторять пока не закончится здоровье игрока или босса
                    //Если босс повережен поздравить и предложить сыграть еще раз
                    //Если игрок повержен предложить начать бой заново
            
        }
    }
}

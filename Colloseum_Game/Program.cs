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
            //Выбор персонажа
            Console.WriteLine($"Кого из своих подданых отправишь на арену, {userName}?");
            
            Console.WriteLine("1 - рыцарь пустоши, 2 - воин горизонта, 3 - северный охотник");
            int characterId = Convert.ToInt32(Console.ReadLine());
     

            //Выбор оружия для персонажа
            Console.WriteLine("Какое оружие дашь ему в руки?");
                var weapon = new Weapon();
                var knight = new Knight(weapon.damageS, weapon.damageF);
            //Описание каждого из видов оружия. Прочитать выбор игрока. Запомнить выбор
            int weaponId = Convert.ToInt32(Console.ReadLine());
                
            //Механика арены с обычным врагом
                //Создание врага
                    int enemyHealth = 5;
                    int enemyDamage = 3;
                //Бой
                while ((knight.Health > 0) & (enemyHealth > 0))
                {
                    knight.Health -=  enemyDamage;
                    Console.WriteLine($"{knight.Health} {enemyHealth}");
                    enemyHealth -= knight.Attack();
                    Console.WriteLine($"{knight.Health} {enemyHealth}");
                    knight.Heal();
                    Console.WriteLine($"{knight.Health} {enemyHealth}");
                    knight.IncreaseDamage();
                    Console.WriteLine($"{knight.Health} {enemyHealth}");
                    if (enemyHealth <= 0)
                    {
                        //Дать подарочек
                        //Завершить бой
                    }
                }
                    //Выбор действия игрока (Атака, Лечение, Увеличение урона)
                    //Атака врага
                    //Повторять пока не закончится здоровье игрока или врага
                    //Если враг повережен дать сундочек с подарком
                    //Если игрок повержен предложить начать бой заново
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
}

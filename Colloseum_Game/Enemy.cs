using System;
namespace Colloseum_Game
{
    public class Enemy 
    {

        public string enemyName;
        public int enemyHealth;


        
        public Enemy()
        {
            Random rnd = new Random();
            enemyName = nameGenerator();
            enemyHealth = rnd.Next(5, 11);

        }

        public static string nameGenerator()
        {
            var rnd = new Random();
            string name;
            string[] femaleAdjectives =
            {
                "Маленькая",
                "Смешная",
                "Глупая",
                "Веселая",
                "Великая",
                "Жирная",
                "Пушистая",
                "Гладкая",
                "Бородавчатая",
                "Забывчивая"
            };

            string[] maleAdjectives =
            {
                "Большой",
                "Могучий",
                "Древний",
                "Визжащий",
                "Ученый",
                "Кривой",
                "Косой",
                "Восковой",
                "Яблочный",
                "Ароматный"
            };

            string[] femaleNouns =
            {
                "Кика",
                "Лмира",
                "Мышк",
                "Сюся",
                "Малинка",
                "Грнока",
                "Ппптка",
                "Брета",
                "Цвуха",
                "Длода"
            };

            string[] maleNouns =
            {
                "Зот",
                "Миредзе",
                "Возг",
                "Зорг",
                "Суперстар",
                "ДАННЫЕ УДАЛЕНЫ",
                "Чмоня",
                "Кит-Кит",
                "Скоттттттт",
                "Олег"
            };

            if (rnd.Next(1, 3) == 1)
            {
                name = maleAdjectives[rnd.Next(0, maleAdjectives.Length)] + ' ' + maleNouns[rnd.Next(0, maleNouns.Length)];
            }
            else
            {
                name = femaleAdjectives[rnd.Next(0, femaleAdjectives.Length)] + ' ' + femaleNouns[rnd.Next(0, femaleNouns.Length)];
            }
            return name;
        }

        public int enemyAttack()
        {
            Random rnd = new Random();
            int damage = rnd.Next(0, 6);
            return damage;
        }
    }
}

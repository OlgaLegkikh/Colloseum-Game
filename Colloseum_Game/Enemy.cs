using System;
namespace Colloseum_Game
{
    public class Enemy 
    {

        public string enemyName;
        public int enemyHealth;


        
        public Enemy()
        {
            var rnd = new Random();
            enemyName = NameGenerator();
            enemyHealth = rnd.Next(5, 20);

        }

        public static string NameGenerator()
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
                "Пупытка",
                "Брета",
                "Цвуха",
                "Длода"
            };

            string[] maleNouns =
            {
                "Зот",
                "Вжмых",
                "Возгр",
                "Жнец",
                "Блоб",
                "ДАННЫЕ_УДАЛЕНЫ",
                "Чмоня",
                "Кит-Кит",
                "Скот",
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

        public int EnemyAttack()
        {
            var rnd = new Random();
            int damage = rnd.Next(0, 6);
            if (damage == 0)
            {
                string[] comments =
                {
                    "Ха-ха, смотрите",
                    "Так сложились звезды, что",
                    "Кому-то нужно поучиться владеть мечом, ведь",
                    "Это явно не его день, потому что",
                    "Не стоило ему выходить на арену, ведь",
                    $"Моя маленькая сестренка управляется мечом лучше, чем {this.enemyName}. Ведь"
                };
                Console.WriteLine($"{comments[rnd.Next(0, comments.Length)]} {this.enemyName} наносит {damage} урона!");
            }
            else
            {
                string[] comments =
                {
                    "Кто-то сегодня в ударе, ведь",
                    "Как круто, что",
                    "Кажется сегодна распродажа элексира везения, потому что",
                    $"Не стоит переходить дорогу {this.enemyName}, ведь",
                    "Не забудьте рассказать про этот бой внукам, ведь"
                };
                Console.WriteLine($"{comments[rnd.Next(0, comments.Length)]} {this.enemyName} наносит {damage} урона!");
            }
            return damage;
        }
    }
}

using System;
namespace Colloseum_Game
{
    public class Knight : Hero
    {
        
        public Knight()
        {
            Name = "Рыцарь пустоши";
            Health = 10;
            Mana = 10;
            _damageS = 0;
            _damageF = 5;

    }


        public override void Heal()
        {
            var rnd = new Random();
            int i = rnd.Next(1, 3);
            Health += i;
            Mana--;
            string[] spellName =
            {
                "Живая вода",
                "Мертвая вода"
            };
            Console.WriteLine($"{Name} применил заклинание {spellName[i]}. Здоровье теперь {Health}");
            Console.WriteLine($"Мана теперь {Mana}");
        }


    }
}

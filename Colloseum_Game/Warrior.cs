using System;
namespace Colloseum_Game
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Name = "Воин горизонта";
            Health = 13;
            Mana = 6;
            _damageS = 0;
            _damageF = 6;
            Console.WriteLine($@"
                {Name} запасся здоровьем на целых {Health} пунктов.
                Легкому мечу предпочитает огромный топор. 
                Выучил несколько заклинаний у старого шамана. Уровень маны - {Mana}.");
        }

        public override void Heal()
        {
            var rnd = new Random();
            int i = rnd.Next(1, 3);
            if (Mana >= 0)
            {
                Health += i;
                Mana--;
                string[] spellName =
                {
                "Вопль павшего",
                "Ледяное сердце"
                };
                Console.WriteLine($"{Name} применил заклинание {spellName[i-1]}. Здоровье теперь {Health}.");
                Console.WriteLine($"Мана теперь {Mana}");
            }
            else
            {
                Console.WriteLine($"{Name} израсходовал всю ману. Здоровье осталось прежним {Health}.");
            }
        }
    }
}

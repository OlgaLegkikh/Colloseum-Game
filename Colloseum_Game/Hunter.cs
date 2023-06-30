using System;
namespace Colloseum_Game
{
    public class Hunter : Hero
    {
        public Hunter()
        {
            Name = "Северный охотник";
            Health = 9;
            Mana = 7;
            _damageS = 1;
            _damageF = 5;
            Console.WriteLine($@"
                {Name}: здоровье {Health} пунктов,
                Владеет кинжалом с максимальным уроном {_damageF} и никогда не промахивается. 
                Учился колдовать у друидов. Уровент маны - {Mana}.");
        }

        public override void Heal()
        {
            var rnd = new Random();
            int i = rnd.Next(1, 4);
            if (Mana >= 0)
            {
                Health += i;
                Mana--;
                string[] spellName =
                {
                "Сила россомахи",
                "Мурчание пумы",
                "Водопой"
                };
                Console.WriteLine($"{Name} применил заклинание {spellName[i-1]}. Здоровье теперь {Health}.");
                Console.WriteLine($"Мана теперь {Mana}.");
            }
            else
            {
                Console.WriteLine($"{Name} израсходовал всю ману. Здоровье осталось прежним {Health}.");
            }
        }
    }
}

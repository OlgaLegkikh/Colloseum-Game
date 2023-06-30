using System;
namespace Colloseum_Game
{
    public class Knight : Hero
    {
        
        public Knight()
        {
            Name = "Рыцарь пустоши";
            Health = 10;
            Mana = 5; //так как рыцарь не умеет колдовать он использует элексиры в качестве маны. Всего у него их 5
            _damageS = 0;
            _damageF = 4;
            Console.WriteLine($@"
                {Name} здоров аж на {Health} пунктов.
                Вооружен легким мечом. Может промахнуться. А может нанести им до {_damageF}.
                Разбирается в эликсирах. Сегодня у него их с собой {Mana}.");

    }


        public override void Heal()
        {
            var rnd = new Random();
            int i = rnd.Next(1, 3);
            if (Mana > 0)
            {
                Health += i;
                Mana--;
                string[] elixirName =
                {
                "Живая вода",
                "Мертвая вода"
                };
                Console.WriteLine($"{Name} выпил эликсир {elixirName[i-1]}. Здоровье теперь - {Health}.");
                Console.WriteLine($"Элексиров осталось {Mana}.");
            }
            else
            {
                Console.WriteLine($"{Name} израсходовал все элексиры! Здоровье осталось прежним - {Health}.");
            };

        }

        public override void IncreaseDamage()
        {
            if (Mana > 0)
            {
                var rnd = new Random();
                int i = rnd.Next(1, 3);
                _damageF += i;
                Mana--;
                string[] elixirName =
                {
                "Живая вода",
                "Мертвая вода"
                };
                Console.WriteLine($"{Name} разбил элексир {elixirName[i]} о свой меч! Урон увеличен! Мана теперь {Mana}.");
            }
            else
            {
                Console.WriteLine($"{Name} израсходовал все элексиры! Урон остался таким же!");
            }
        }



    }
}

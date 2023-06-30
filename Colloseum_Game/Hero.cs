using System;
namespace Colloseum_Game
{
    public abstract class Hero
    {
        public string Name;
        public int Health;
        public int Mana;
        protected int _damageS;
        protected int _damageF;
        public Hero()
        {
        }

        public abstract void Heal();


        public int Attack()
        {
            var rnd = new Random();
            var balabol = new Balabol();
            int damage = rnd.Next(_damageS, _damageF + 1);
            Console.WriteLine($"{Name} наносит {damage} урона.{Environment.NewLine}{balabol.AttackComment(damage)}");
            return damage;
        }

        
        public virtual void IncreaseDamage()
        {
            if (Mana >= 2)
            {
                _damageF++;
                Mana -= 2;
                Console.WriteLine($"Урон увеличен! Мана теперь {Mana}.");
            }
            else
            {
                Console.WriteLine($"Увы вам не хватило маны. Урон остался таким же.");
            }

        }
        

    }
}

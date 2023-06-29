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

        public int Attack()
        {
            var rnd = new Random();
            var balabol = new Balabol();
            int damage = rnd.Next(_damageS, _damageF + 1);
            Console.WriteLine($"{Name} наносит {damage} урона.{Environment.NewLine}{balabol.knightAttackComment(damage)}");
            return damage;
        }

        public abstract void Heal();
        public void IncreaseDamage()
        {
             _damageF++;
             Mana -= 2;
             Console.WriteLine($"Урон увеличен! мана теперь {Mana}.");


        }

        public virtual
        

    }
}

using System;
namespace Colloseum_Game
{
    public class Knight
    {
        public int Health = 10;
        public int Mana = 10;
        private int _damageS;
        private int _damageF;
        public Knight(int damageS, int damageF)
        {
            _damageS = damageS;
            _damageF = damageF;
        }

        
        public int Attack()
        {
            var rnd = new Random();
            int damage = rnd.Next(_damageS, _damageF + 1);
            return damage;
        }

        public void Heal()
        {
            var rnd = new Random();
            Health += rnd.Next(1, 3);
            Mana--;
        }

        public void IncreaseDamage()
        {
            _damageF++;
            Mana -= 2;
            
        }

    }
}

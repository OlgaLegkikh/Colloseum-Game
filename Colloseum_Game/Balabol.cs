﻿using System;
namespace Colloseum_Game
{
    public class Balabol
    {
        public Balabol()
        {
        }

        //Обращение к игроку
        public string appealToUser()
        {
            var rnd = new Random();
            string[] appeals =
            {
                "храбрец",
                "молодец",
                "удалец",
                "человек",
                "новичок",
                "глупец",
                "смельчак",
                "герой"
            };
            return appeals[rnd.Next(0, appeals.Length)];
        }
        //Комментарий
        public string comment(int commentType)
        {
            
                string[] comments =
                {
                "Отличный выбор!",
                "Будет сделано!",
                "Так и поступим",
                "Как скажите!",
                "И так тоже можно!",
                "Должно получится!",
                "Все получится!",
                "Вперед!",
                "Ну что ж...",
                "Таков путь...",
                "Раз вы так сказали!",
                "Приказы не обсуждают!",
                "Странное стратегическое решение, но ладно.",
                "Оки-доки"
            };
                var rnd = new Random();


            return comments[rnd.Next(0, comments.Length)];

           
            
        }

        public string AttackComment(int damage)
        {
            var rnd = new Random();
            if (damage == 0)
            {
                
                string[] comments =
                    {
                    "Мда. Говорила мне мама не ставь на рыцарей",
                    "Даже моя бабулита владеет оружием лучше",
                    "Ну ничего ничего. С такими темпами этот малыш скоро пойдет баиньки",
                    "Похихикали и хватит",
                    "А разговоров то было",
                    "Не думаю, что его сопернику так повезет еще раз",
                    "Сопернику просто повезло увернуться",
                    };
                return comments[rnd.Next(0, comments.Length)];
                
            }
            else
            {
                string[] comments =
                    {
                    "В целом неплохо, но можно и лучше",
                    "Вперед! Вперед! ВПЕРЕЕЕЕЕД!",
                    "Не зря на него ставил",
                    "Ура! Я слышу, как толпа на арене ликует!",
                    "Это хорошо? Нет это просто великолепно",
                    "Кажется его соперник, сегодня забыл свои счастливые носки",
                    "Я бы не стал переходить ему дорогу",
                    };
                return comments[rnd.Next(0, comments.Length)];
            }
            
        }


    }
}

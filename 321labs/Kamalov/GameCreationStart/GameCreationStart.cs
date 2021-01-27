using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.Kamalov.GameCreationStart
{
    class GameCreationStart
    {
        private static List<GameCreationStart> listOfUsers = new List<GameCreationStart>();
        private string Nick_Name;
        private DateTime BirthDay;
        private int EndMatch;
        private int Wins;
        private int Points;

        public string UserName
        {
            get => Nick_Name;
            set => Nick_Name = value;
        }
        public DateTime DayOfBirth
        {
            get => BirthDay;
            set => BirthDay = value;
        }
        public int FinishedMatches
        {
            get => EndMatch;
            set => EndMatch = value;
        }
        public int Victories
        {
            get => Wins;
            set => Wins = value;
        }
        public int GamePoints
        {
            get => Points;
            set => Points = value;
        }

        public GameCreationStart(string nick_name, DateTime birthday)
        {
            this.Nick_Name = nick_name;
            this.BirthDay = birthday;
            listOfUsers.Add(this);
        }
        public static void SearchByName(string name)
        {
            List<GameCreationStart> nick_name = new List<GameCreationStart>();
            Parallel.ForEach(listOfUsers, x =>
            {
                if (name == x.Nick_Name)
                {
                    nick_name.Add(x);

                }
            });
            foreach (var item in nick_name)
            {
                Console.WriteLine($"Дата рождения: {item.BirthDay} | Оконченные матчи: {item.EndMatch} | Победы: {item.Wins} | Очки: {item.Points}");
            }
        }

        public int Statistic()
        {
            return this.EndMatch;
        }
    }
}
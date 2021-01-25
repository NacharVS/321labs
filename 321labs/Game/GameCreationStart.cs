using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class GameCreationStart
    {
        string userName;           //Имя пользователя.
        DateTime dayOfBirth;      //День рождения.
        int finishedMatches;     //Законченные матчи.
        int victories;          //Победы.
        int gamePoints;        //Игровые очки.

        public string UserName { get => userName; set => userName = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        public int Victories { get => victories; set => victories = value; }
        public int GamePoints { get => gamePoints; set => gamePoints = value; }

        public GameCreationStart (string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            this.userName = userName;
            this.dayOfBirth = dayOfBirth;
            this.finishedMatches = finishedMatches;
            this.victories = victories;
            this.gamePoints = gamePoints;
        }

        public static GameCreationStart SearchByName(GameCreationStart hero)
        {
            Console.WriteLine($"Имя пользователя - {hero.UserName}" +
                              $"\nДень рождения - {hero.DayOfBirth}" +
                              $"\nЗаконченные матчи - {hero.FinishedMatches}" +
                              $"\nПобеды - {hero.victories}" +
                              $"\nИгровые очки - {hero.GamePoints}");
            Console.WriteLine(); 

            return hero;
        }

        public void GameStat()
        {
            
        }
    }
}

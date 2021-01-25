using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game.Users_info
{
    class User { 
    public string UserName { get; set; }
    public DateTime DayOfBirth { get; set; }
    public int FinishedMatches { get; set; }
    public int Victories { get; set; }
    public int MMR { get; set; }

    public GameCreationStart(string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
    {
        UserName = userName;
        DayOfBirth = dayOfBirth;
        FinishedMatches = finishedMatches;
        Victories = victories;
        MMR = gamePoints;
       
    }


}
}

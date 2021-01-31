using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Ydin321.GameCreationStart
{
    class GameCreationStart
    {
        private string username;
        private int finishedmatches;
        private int victories;
        private int gamepoints;
        private DateTime date1;

        public string UserName
        {
            get
            {
                return username;
            }
            private set
            {
                username = value;
            }
        }
        public DateTime Date1
        {
            get
            {
                return date1;
            }
            private set
            {
                date1 = value;
            }
        }
    }
}

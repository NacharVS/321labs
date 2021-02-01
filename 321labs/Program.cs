using System;
using System.Threading;
using System.Threading.Tasks;
using _321labs.Koshelev.Game;
using _321labs.Koshelev.Thread;
using _321labs.Koshelev;
using _321labs.Game;


namespace _321labs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior
            {
                Helth = 100,
                Damage = 37,
                Range = 10,
                Speed = 46
            };
            MongoCRUD mongoCRUD = new MongoCRUD("OtkritiyRot");
            mongoCRUD.ConnectionMongoDatabase();
            mongoCRUD.CreatNewDataInCollection<Warrior>("Chelust", warrior);


        }
      
    }
}

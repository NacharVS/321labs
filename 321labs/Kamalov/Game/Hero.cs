
namespace _321labs.Kamalov.Game
{
    abstract class Hero
    {
       public int Health { get; set; }
       public int Speed { get; set; }
       public string Name { get; set; }
       public int Damage { get; set; }
        

        public Hero(int health, int speed, string name, int damage)
        {
            Health = health;
            Speed = speed;
            Name = name;
            Damage = damage;
        }
    }
}
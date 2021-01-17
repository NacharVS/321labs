
namespace _321labs.Kamalov.Game
{
    abstract class Hero : IHero
    {
       public int Health { get ; set; }
       public int Speed { get; set; }
       public string Name { get; set; }
       public int Damage { get; set; }
        

        public Hero(int health, int speed, string name, int damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
        }
    }
}
namespace _321labs.Game
{
    interface IUnit
    {
        int Helth { get; set; }
        int Damage { get; set; }
        int Speed { get; set; }
        int Range { get; set; }
        double PositionX { get; set; }
        double PositionY { get; set; }

    }
}

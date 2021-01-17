using System;
using _321labs.Game.inteface;
public class Archer : Iunit
{
    public int Health { get; set; }
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public int PositionZ { get; set; }
    public int Damage { get; set; }
    public int armor { get; set; }


    public void TakeDamage()
    {
        Console.WriteLine("Выстрел из лука");
    }





}


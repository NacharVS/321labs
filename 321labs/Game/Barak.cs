using System;
using _321labs.Game;
using _321labs.Game.inteface;
public class Barak : Ibarak, Iunit
{
	public int Health { get ; set ; }
	public int PositionX { get ; set ; }
	public int PositionY { get ; set ; }
	public int PositionZ { get ; set ; }
	public int armor { get ; set ; }
	public int CountLife { get; set; }


	public void Count()
	{
		Console.WriteLine("Живет(кол-во)" );
	}
}

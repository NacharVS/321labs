using System;
using _321labs.Game.inteface;
using _321labs.intaface;


public class Berserk : Iunit, Iattack
{
	public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int PositionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int PositionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int PositionZ { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


	public void TakeDamage()
	{
		Console.WriteLine("Ударил");
	}

	public	void Stop()
	{
		Console.WriteLine("Стоит");

	}
}

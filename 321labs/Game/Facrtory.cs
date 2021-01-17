using System;
using System.Collections.Generic;
using System.Text;
using _321labs.Game.inteface;
using _321labs.intaface;


public class Factory : Iunit
{
	public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int PositionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int PositionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int PositionZ { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public void proizvodit()
	{
		Console.WriteLine("Сделал что нибудь");
	}
}

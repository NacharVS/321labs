using System;
using _321labs.Treads;
using _321labs.Synh;
using _321labs.Task_;
namespace _321labs
{
	class Program
	{
		static void Main(string[] args)
		{

			ThreadLocker threadLocker = new ThreadLocker();
			threadLocker.start();
			
;
			TaskThreading taskThreading = new TaskThreading();
			taskThreading.start();
			
		}
	}
}

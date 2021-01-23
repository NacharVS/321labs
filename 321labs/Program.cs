using System;
using _321labs.Treads;
using _321labs.Synh;
using _321labs.Task_;
using _321labs.ContinuationTasks;

using _321labs.Canseltas;

namespace _321labs
	
{
	class Program
	{
		static void Main(string[] args)
		{


			

			CancelTasks canseltask = new CancelTasks();
			canseltask.start();

		}
	}
}

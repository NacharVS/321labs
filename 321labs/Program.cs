using _321labs.Treads;

namespace _321labs
{
	class Program
	{
		static void Main(string[] args)
		{

			Threads threads = new Threads(new[] { 15, 35, 6, 28, 49, 58, 19, 35, 9, 84, 4, 1, 9, 4, 16, 5 });
			threads.Start();

		}
	}
}

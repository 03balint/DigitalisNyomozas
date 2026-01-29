using System.Linq.Expressions;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyítékok kezelése\n4. Idővonal megtekintése\n5. Elemzés / döntések\n6. Kilépés");
			ConsoleKey key;
			key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
					// code block
					break;
				case ConsoleKey.D2:
					// code block
					break;
				case ConsoleKey.D3:
					// code block
					break;
				case ConsoleKey.D4:
					// code block
					break;
				case ConsoleKey.D5:
					// code block
					break;
				case ConsoleKey.D6:
					Environment.Exit(0);
					break;

			}
		}
    }
}

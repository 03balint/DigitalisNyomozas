using System.Linq.Expressions;

namespace DigitalisNyomozas
{
    internal class Program
    {
		static DataStore dataStore;
		static EvidenceManager evidenceManager;
        static void Main(string[] args)
        {
			dataStore = new DataStore();
			evidenceManager= new EvidenceManager(dataStore);
			Menu();

		}

		static void Menu()
		{
			Console.Clear();
			Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyítékok kezelése\n4. Idővonal megtekintése\n5. Elemzés / döntések\n6. Kilépés");
			ConsoleKey key;
			key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
					UgyMenu();
					break;
				case ConsoleKey.D2:
					SzemelyekMenu();
					break;
				case ConsoleKey.D3:
					BizonyitekMenu();
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
		static void SzemelyekMenu()
		{
			string nev;
			int eletkor;
			string megjegyzes;
			Console.Clear();
			Console.WriteLine("1. Személy hozzáadása\n2. Személy törlése\n3. Személyek listázása");
			ConsoleKey key;
			key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
					Console.Clear();
					Console.WriteLine("--- Személy hozzáadása ---");
					Console.Write("Név: ");
					nev = Console.ReadLine();
					Console.Write("Életkor: ");
					eletkor = int.Parse(Console.ReadLine());
					Console.Write("Megjegyzés: ");
					megjegyzes = Console.ReadLine();

					Person p = new Person(nev,eletkor,megjegyzes);

					dataStore.Szemelyek.Add(p);

					Console.WriteLine("\nSzemély hozzádva");
					Thread.Sleep(1000);
					Menu();
					break;
				case ConsoleKey.D2:
					Console.Clear();
					Console.WriteLine("--- Személy Törlése ---");
					Console.Write("Személy sorszáma: ");
					int sorszam = int.Parse(Console.ReadLine());


					dataStore.Szemelyek.RemoveAt(sorszam-1);

					Console.WriteLine("\nSzemély törölve");
					Thread.Sleep(1000);


					Menu();
					break;
				case ConsoleKey.D3:
					Console.Clear();
					int index = 1;
					Console.WriteLine("Személyek:");
					foreach (Person item in dataStore.Szemelyek)
					{
						Console.WriteLine(index + ". " + item);
						index++;
					}

					Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
					key = Console.ReadKey(true).Key;
					Menu();
					break;


			}

		}
		static void BizonyitekMenu()
		{
			string azonosito;
			string tipus;
			string leiras;
			int megbizhatosag;
			
			Console.Clear();
			Console.WriteLine("1. Bizonyíték hozzáadása\n2. Bizonyíték törlése\n3. Bizonyítékok listázása");
			ConsoleKey key;
			key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
					Console.Clear();
					Console.WriteLine("--- Bizonyíték hozzáadása ---");
					Console.Write("Azonosító: ");
					azonosito=Console.ReadLine();
					Console.Write("Típus: ");
					tipus = Console.ReadLine();
					Console.Write("Leírás: ");
					leiras = Console.ReadLine();
					Console.Write("Megbízhatósági érték (1-5): ");
					megbizhatosag =int.Parse(Console.ReadLine());
					
					Evidence e =new Evidence(azonosito, tipus, leiras,megbizhatosag);	

					evidenceManager.BizonyitekHozzadasa(e);
					
					Console.WriteLine("\nBizonyítek hozzádva");
					Thread.Sleep(1000);
					Menu();
					break;
				case ConsoleKey.D2:
					Console.Clear();
					Console.WriteLine("--- Bizonyíték Törlése ---");
					Console.Write("Bizonyíték sorszáma: ");
					int sorszam = int.Parse(Console.ReadLine());


					evidenceManager.BizonyitekTorlese(sorszam);

					Console.WriteLine("\nBizonyítek törölve");
					Thread.Sleep(1000);


					Menu();
					break;
				case ConsoleKey.D3:
					Console.Clear();
					dataStore.BizonyitekListazas();

					Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
					key = Console.ReadKey(true).Key;
					Menu();
					break;


			}
		}

		static void UgyMenu()
		{

		}
    }
}

using System.Linq.Expressions;

namespace DigitalisNyomozas
{
    internal class Program
    {
		static DataStore dataStore;
		static EvidenceManager evidenceManager;
		static CaseManager caseManager;
		static TimelineEvent idovonal;
		static DecisionEngine decisionEngine;
        static void Main(string[] args)
        {
			dataStore = new DataStore();
			evidenceManager= new EvidenceManager(dataStore);
			caseManager =new CaseManager(dataStore);
			Menu();

		}

		static void Menu()
		{
			Console.Clear();
			Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyítékok kezelése\n4. Idővonal megtekintése\n5. Elemzés\n6. Kilépés");
			ConsoleKey key;
			key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
					UgyMenu();
					break;
				case ConsoleKey.D2:
					SzemelyKezMenu();
					break;
				case ConsoleKey.D3:
					BizonyitekMenu();
					break;
				case ConsoleKey.D4:
					IdovonalMenu();
					break;
				case ConsoleKey.D5:
					ElemzesMenu();
					break;
				case ConsoleKey.D6:
					Environment.Exit(0);
					break;

			}
		}
		static void UgyMenu() 
		{
			string ugy_azonosito;
			string cim;
			string leiras;
			string allapot;


			Console.Clear();
			Console.WriteLine("1. Új ügy létrehozása\n2. Ügy törlése\n3. Ügyek listázása\n4. Személy/Bizonyíték hozzárendelése\n5. Ügy állapotának módosítása \n 6. Vissza");
			ConsoleKey key;
			key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
					Console.Clear();
					Console.WriteLine("--- Ügy hozzáadása ---");
					Console.Write("Ügy azonosító: ");
					ugy_azonosito = Console.ReadLine();
					Console.Write("Cím: ");
					cim = Console.ReadLine();
					Console.Write("Leírás: ");
					leiras = Console.ReadLine();
					Console.Write("Állapot: ");
					allapot = Console.ReadLine();


					Case c = new Case(ugy_azonosito, cim, leiras, allapot, new List<Person>(), new List<Evidence>());

					caseManager.UgyHozzaadasa(c);

					Console.WriteLine("\nÜgy hozzádva");
					Thread.Sleep(1000);
                    UgyMenu();
					break;
				case ConsoleKey.D2:
					Console.Clear();
					Console.WriteLine("--- Ügy Törlése ---");
					Console.Write("Ügy sorszáma: ");
					int sorszam = int.Parse(Console.ReadLine());


					caseManager.UgyTorlese(sorszam);

					Console.WriteLine("\nÜgy törölve");
					Thread.Sleep(1000);


                    UgyMenu();
					break;
				case ConsoleKey.D3:
					Console.Clear();
					dataStore.UgyekListazas();

					Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
					key = Console.ReadKey(true).Key;
                    UgyMenu();
					break;
				case ConsoleKey.D4:
					Console.Clear();
					Console.WriteLine("--- Személy és Bizonyíték hozzárendelése ---");

					Console.WriteLine("Ügy sorszáma: ");
					int cSorszam = int.Parse(Console.ReadLine());

					Console.WriteLine("Személy sorszáma: ");
					int szSorszam=int.Parse(Console.ReadLine());

					Console.WriteLine("Bizonyíték sorszáma: ");
					int bSorszam = int.Parse(Console.ReadLine());

					Person szemely = dataStore.Szemelyek[szSorszam-1];

					Evidence bizonyitek = dataStore.Bizonyitekok[bSorszam-1];

					dataStore.Ugyek[cSorszam].szemelyek.Add(szemely);

					dataStore.Ugyek[cSorszam].bizonyitekok.Add(bizonyitek);


                    UgyMenu();
					break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("--- Ügy állapotának módosítása ---");

                    Console.WriteLine("Ügy sorszáma: ");
                    int cmSorszam = int.Parse(Console.ReadLine());

                    Console.Write("Állapot: ");
                    string cmallapot = Console.ReadLine();

					dataStore.Ugyek[cmSorszam - 1].Allapot = cmallapot;

                    Console.WriteLine("\nÜgy módosítva");
                    Thread.Sleep(1000);

                    UgyMenu();
					break;

				case ConsoleKey.D6:
					Menu();
					break;
            }
		}
		static void SzemelyKezMenu()
		{
            Console.Clear();
            Console.WriteLine("1. Személyek Kezelése\n2. Tanuk kezelése\n3. Gyanusítottak kezelése\n4. Vissza");
            ConsoleKey key;
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    SzemelyMenu();
                    break;
                case ConsoleKey.D2:
                    TanuMenu();
                    break;
                case ConsoleKey.D3:
                    GyanusitottMenu();
                    break;
                case ConsoleKey.D4:
                    Menu();
                    break;


            }
        }
		static void TanuMenu()
		{
            Console.Clear();
            Console.WriteLine("1. Tanu hozzáadása\n2. Tanu törlése\n3. Tanuk listázása\n4. Vissza");
            ConsoleKey key;
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("--- Tanu hozzáadása ---");
                    Console.Write("Név: ");
                    string nev = Console.ReadLine();
                    Console.Write("Életkor: ");
                    int eletkor = int.Parse(Console.ReadLine());
                    Console.Write("Megjegyzés: ");
                    string megjegyzes = Console.ReadLine();
                    Console.Write("Vallomás szövege: ");
                    string vallomas = Console.ReadLine();
                    Console.Write("Vallomás dátuma: ");
                    DateTime vallomasdatuma =DateTime.Parse(Console.ReadLine());

                    Person p = new Person(nev, eletkor, megjegyzes);

                    Witness w = new Witness(p, vallomas, vallomasdatuma);

                    dataStore.Tanuk.Add(w);

                    Console.WriteLine("\nTanu hozzádva");
                    Thread.Sleep(1000);
                    TanuMenu();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("--- Tanu Törlése ---");
                    Console.Write("Tanu sorszáma: ");
                    int sorszam = int.Parse(Console.ReadLine());


                    dataStore.Tanuk.RemoveAt(sorszam - 1);

                    Console.WriteLine("\nTanu törölve");
                    Thread.Sleep(1000);


                    TanuMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    int index = 1;
                    Console.WriteLine("Tanuk:");
                    foreach (Witness item in dataStore.Tanuk)
                    {
                        Console.WriteLine(index + ". " + item);
                        index++;
                    }

                    Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
                    key = Console.ReadKey(true).Key;
                    TanuMenu();
                    break;

                case ConsoleKey.D4:
					SzemelyKezMenu();
                    break;

            }
        }
		static void GyanusitottMenu()
		{
            Console.Clear();
            Console.WriteLine("1. Gyanusított hozzáadása\n2. Gyanusított törlése\n3. Gyanusítottak listázása\n4. Vissza");
            ConsoleKey key;
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("--- Gyanusított hozzáadása ---");
                    Console.Write("Név: ");
                    string nev = Console.ReadLine();
                    Console.Write("Életkor: ");
                    int eletkor = int.Parse(Console.ReadLine());
                    Console.Write("Megjegyzés: ");
                    string megjegyzes = Console.ReadLine();

                    Console.Write("Gyanusítottsági szint: ");
                    int gyanusitottsagiSzint = int.Parse(Console.ReadLine());

                    Console.Write("Státusz: ");
                    string statusz = Console.ReadLine();

                    Person p = new Person(nev, eletkor, megjegyzes);

                    Suspect s = new Suspect(p, gyanusitottsagiSzint, statusz);

                    dataStore.Gyanusitottak.Add(s);

                    Console.WriteLine("\nGyanusított hozzádva");
                    Thread.Sleep(1000);
                    GyanusitottMenu();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("--- Gyanusított Törlése ---");
                    Console.Write("Gyanusított sorszáma: ");
                    int sorszam = int.Parse(Console.ReadLine());


                    dataStore.Gyanusitottak.RemoveAt(sorszam - 1);

                    Console.WriteLine("\nGyanusított törölve");
                    Thread.Sleep(1000);


                    GyanusitottMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    int index = 1;
                    Console.WriteLine("Gyanusítottak:");
                    foreach (Suspect item in dataStore.Gyanusitottak)
                    {
                        Console.WriteLine(index + ". " + item);
                        index++;
                    }

                    Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
                    key = Console.ReadKey(true).Key;
                    GyanusitottMenu();
                    break;

                case ConsoleKey.D4:
                    SzemelyKezMenu();
                    break;
            }
        }
		static void SzemelyMenu()
		{
            string nev;
            int eletkor;
            string megjegyzes;
            Console.Clear();
            Console.WriteLine("1. Személy hozzáadása\n2. Személy törlése\n3. Személyek listázása\n4. Vissza");
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

                    Person p = new Person(nev, eletkor, megjegyzes);

                    dataStore.Szemelyek.Add(p);

                    Console.WriteLine("\nSzemély hozzádva");
                    Thread.Sleep(1000);
                    SzemelyMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("--- Személy Törlése ---");
                    Console.Write("Személy sorszáma: ");
                    int sorszam = int.Parse(Console.ReadLine());


                    dataStore.Szemelyek.RemoveAt(sorszam - 1);

                    Console.WriteLine("\nSzemély törölve");
                    Thread.Sleep(1000);


                    SzemelyMenu();
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
                    SzemelyMenu();
                    break;

                case ConsoleKey.D4:
                    SzemelyKezMenu();
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
			Console.WriteLine("1. Bizonyíték hozzáadása\n2. Bizonyíték törlése\n3. Bizonyítékok listázása\n4. Vissza");
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
                    BizonyitekMenu();
					break;
				case ConsoleKey.D2:
					Console.Clear();
					Console.WriteLine("--- Bizonyíték Törlése ---");
					Console.Write("Bizonyíték sorszáma: ");
					int sorszam = int.Parse(Console.ReadLine());


					evidenceManager.BizonyitekTorlese(sorszam);

					Console.WriteLine("\nBizonyítek törölve");
					Thread.Sleep(1000);


                    BizonyitekMenu();
					break;
				case ConsoleKey.D3:
					Console.Clear();
					dataStore.BizonyitekListazas();

					Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
					key = Console.ReadKey(true).Key;
                    BizonyitekMenu();
					break;
				case ConsoleKey.D4:
					Menu();
					break;

			}
		}
		static void IdovonalMenu()
		{
            DateTime datum;

            string leiras;


            Console.Clear();
            Console.WriteLine("1. Esemény hozzáadása\n2. Esemény törlése\n3. Idővonal megtekintése\n4. Vissza");
            ConsoleKey key;
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("--- Esemény hozzáadása ---");
                    Console.Write("Dátum: ");
                    datum = DateTime.Parse(Console.ReadLine());
                    Console.Write("Leírás: ");
                    leiras = Console.ReadLine();

                    TimelineEvent t = new TimelineEvent(datum, leiras);

                    idovonal.EsemenyHozzadása(t);

                    Console.WriteLine("\nEsemény hozzádva");
                    Thread.Sleep(1000);
                    IdovonalMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("--- Esemény Törlése ---");
                    Console.Write("Esemény sorszáma: ");
                    int sorszam = int.Parse(Console.ReadLine());


                    idovonal.EsemenyTorlese(sorszam);

                    Console.WriteLine("\nEsemény törölve");
                    Thread.Sleep(1000);


                    IdovonalMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    dataStore.BizonyitekListazas();

                    Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
                    key = Console.ReadKey(true).Key;
                    IdovonalMenu();
                    break;
                case ConsoleKey.D4:
                    Menu();
                    break;

            }
        }
		static void ElemzesMenu()
		{

			
		}
    }
}

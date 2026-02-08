using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class DataStore
	{
		private List<User> felhasznalok;
		private List<Case> ugyek;
		private List<Person> szemelyek;
		private List<Evidence> bizonyitekok;
        private List<Witness> tanuk;
        private List<Suspect> gyanusitottak;

        public DataStore()
		{
			this.felhasznalok =new List<User>();
			this.ugyek = new List<Case>();
			this.szemelyek =new List<Person>();
			this.bizonyitekok = new List<Evidence>();
            this.tanuk = new List<Witness>();
            this.gyanusitottak = new List<Suspect>();

        }

		internal List<User> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
		internal List<Case> Ugyek { get => ugyek; set => ugyek = value; }
		internal List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        internal List<Witness> Tanuk { get => tanuk; set => tanuk = value; }
        internal List<Suspect> Gyanusitottak { get => gyanusitottak; set => gyanusitottak = value; }


        public void BizonyitekListazas()
		{
			int sorszam = 1;
			Console.WriteLine("Bizonyítékok:");
			foreach (Evidence item in Bizonyitekok)
			{
				Console.WriteLine(sorszam+". "+item);
				sorszam++;
			}
		}
		public void UgyekListazas()
		{
			int sorszam = 1;
			Console.WriteLine("Ügyek:");
			foreach (Case item in Ugyek)
			{
				Console.WriteLine(sorszam + ". " + item);
				sorszam++;
			}
		}
	}
}

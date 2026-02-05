using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseManager
	{
		private DataStore tarhely;

		public CaseManager(DataStore tarhely)
		{
			this.tarhely = tarhely;
		}

		public void UgyHozzaadasa(Case x)
		{
			this.tarhely.Ugyek.Add(x);
		}
		public void UgyTorlese(int x)
		{
			if (x <= tarhely.Ugyek.Count)
			{
				this.tarhely.Ugyek.RemoveAt(x - 1);
			}
			else { Console.WriteLine("Nincs ilyen sorszámú adat!"); }
		}

	}
}

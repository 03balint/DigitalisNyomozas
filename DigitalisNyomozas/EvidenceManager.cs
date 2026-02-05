using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class EvidenceManager
	{
		private DataStore tarhely;

		public EvidenceManager(DataStore tarhely) 
		{
			 this.tarhely = tarhely;
		}
		public void BizonyitekHozzadasa(Evidence x) 
		{

			this.tarhely.Bizonyitekok.Add(x);
			
		}
		public void BizonyitekTorlese(int x) 
		{
			if (x <= tarhely.Bizonyitekok.Count)
			{
				this.tarhely.Bizonyitekok.RemoveAt(x-1);
			}
			else { Console.WriteLine("Nincs ilyen sorszámú adat!"); }
		}

	}
}

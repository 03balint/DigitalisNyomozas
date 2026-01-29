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
		public void BizonyitekTorlese(Evidence x) 
		{
			this.tarhely.Bizonyitekok.Remove(x);
		}
		public void BizonyitekListazas()
		{
			foreach (Evidence item in this.tarhely.Bizonyitekok)
			{
				Console.WriteLine(item);
			}
		}
	}
}

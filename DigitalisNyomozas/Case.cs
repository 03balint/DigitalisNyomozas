using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Case
	{
		private string ugy_azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<string> szemelyek;
		private List<string> bizonyitekok;

		public Case(string ugy_azonosito, string cim, string leiras, string allapot, List<string> szemelyek, List<string> bizonyitekok)
		{
			this.ugy_azonosito = ugy_azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
		}

		public string Ugy_azonosito { get => ugy_azonosito; set => ugy_azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public List<string> Szemelyek { get => szemelyek; set => szemelyek = value; }
		public List<string> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
		internal string Allapot { get => allapot; set => allapot = value; }

		public override string ToString()
		{
			return $"Azonosító: {ugy_azonosito}; cím: {cim}; leírás: {leiras}; állapot: {allapot}";
		}
	}
	
}

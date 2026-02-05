using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Evidence
	{
		private string azonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosagi_ertek;

		public Evidence(string azonosito, string tipus, string leiras, int megbizhatosagi_ertek)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagi_ertek = megbizhatosagi_ertek;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int Megbizhatosagi_ertek { get => megbizhatosagi_ertek; set => megbizhatosagi_ertek = value; }

		public override string ToString()
		{
			return $"Azonosító: {azonosito}; Típus: {tipus}; Leírás: {leiras}; Megbízhatósági érték: {megbizhatosagi_ertek}";
		}
	
	}
	

}

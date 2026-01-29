using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Witness
	{
		private Person tanu;
		private string vallomas_szovege;
		private string vallomas_datuma;

		public Witness(Person tanu, string vallomas_szovege, string vallomas_datuma)
		{
			this.tanu = tanu;
			this.vallomas_szovege = vallomas_szovege;
			this.vallomas_datuma = vallomas_datuma;
		}

		public string Vallomas_szovege { get => vallomas_szovege; set => vallomas_szovege = value; }
		public string Vallomas_datuma { get => vallomas_datuma; set => vallomas_datuma = value; }
		internal Person Tanu { get => tanu; set => tanu = value; }
	}
}

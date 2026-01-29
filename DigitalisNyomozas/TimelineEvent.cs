using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class TimelineEvent
	{
		private DateTime datum;
		private string esemeny_leirasa;

		public TimelineEvent(DateTime datum, string esemeny_leirasa)
		{
			this.datum = datum;
			this.esemeny_leirasa = esemeny_leirasa;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string Esemeny_leirasa { get => esemeny_leirasa; set => esemeny_leirasa = value; }
	}
}

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
		private List<TimelineEvent> idovonal;

		public TimelineEvent(DateTime datum, string esemeny_leirasa)
		{
			this.datum = datum;
			this.esemeny_leirasa = esemeny_leirasa;
			this.idovonal = new List<TimelineEvent>();
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string Esemeny_leirasa { get => esemeny_leirasa; set => esemeny_leirasa = value; }
        internal List<TimelineEvent> Idovonal { get => idovonal; set => idovonal = value; }

		public void EsemenyHozzadása(TimelineEvent x)
		{
			this.idovonal.Add(x);
		}
        public void EsemenyTorlese(int x)
        {
            if (x <= idovonal.Count)
            {
                this.idovonal.RemoveAt(x - 1);
            }
            else { Console.WriteLine("Nincs ilyen sorszámú adat!"); }
        }

		public void IdovonalKiiras()
		{
			var rendezett = idovonal.OrderBy(e => e.Datum);
            foreach (var e in rendezett)
            {
                Console.WriteLine(e);
            }
        }

        public override string ToString()
        {
            return $"{datum:yyyy-MM-dd}: {esemeny_leirasa}";
        }
    }
}

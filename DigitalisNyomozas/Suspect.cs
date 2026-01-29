using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Suspect
	{
		private Person gyanusitott;
		private int gyanusitottsagi_szint;
		private string status;

		public Suspect(Person gyanusitott, int gyanusitottsagi_szint, string status)
		{
			this.gyanusitott = gyanusitott;
			this.gyanusitottsagi_szint = gyanusitottsagi_szint;
			this.status = status;
		}

		public int Gyanusitottsagi_szint { get => gyanusitottsagi_szint; set => gyanusitottsagi_szint = value; }
		public string Status { get => status; set => status = value; }
		internal Person Gyanusitott { get => gyanusitott; set => gyanusitott = value; }
	}
}

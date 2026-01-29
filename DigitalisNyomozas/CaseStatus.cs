using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseStatus
	{
		private string status;

		public CaseStatus(string status)
		{
			this.status = status;
		}

		public string Status { get => status; set => status = value; }
	}
}

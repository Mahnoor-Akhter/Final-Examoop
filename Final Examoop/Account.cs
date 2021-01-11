using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Examoop
{
	public abstract class Account
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public decimal Balance { get; private set; }

		public int interestDate { get; set; }
	}
}

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

		public double interestDate { get; set; }

		public abstract decimal CalulateInterest();

		public Account(string firstname ,string lastname , decimal balance, int interesrdate)
		{
			FirstName = firstname;
			LastName = lastname;
			Balance = balance;
			interestDate = interesrdate;

		}

		protected Account(string firstname, string lastname, decimal balance, double interestdate)
		{
			FirstName = firstname;
			LastName = lastname;
			Balance = balance;
			interestDate = interestdate;
		}

		//Output display in list box
		public override string ToString()
		{
			return string.Format($"{LastName.ToUpper()},{FirstName}");
		}

		internal static void Add(Account ca1)
		{
			throw new NotImplementedException();
		}
	}

}

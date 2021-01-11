using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Examoop
{
	 public class Savings_Account : Account
	{

		public Savings_Account(string firstname, string lastname, decimal balance, double interestdate) : base(firstname, lastname, balance,interestdate)
		{
			Balance = balance;
		}
           public decimal Balance { get; set; }
		public override decimal CalulateInterest()
		{
			return Balance * (decimal)0.06;

			//set Data Time
		}

		public override string ToString()
		{
			return base.ToString() + "-Savings account";
		}
	}
	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Examoop
{
	public class Current_Account : Account
	{
		public Current_Account(string firstname , string lastname, decimal balance, double  interestdate) :base(firstname ,lastname ,balance,intersetdate)
		{
			Balance = balance;
		}
		public decimal Balance { get; set; }
		public override decimal CalulateInterest()
		{
			return Balance * (decimal)0.03;

			//set date time
		}


		public override string ToString()
		{
			return base.ToString() + "-Current Account";
		}
	}
}

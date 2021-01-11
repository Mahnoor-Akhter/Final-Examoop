using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Examoop
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Account LbxName__SelectionItem;
		private object ca;
		public List<Account> accounts;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender , RoutedEventArgs e)
		{
			
			
			// CurrentAccount (fistname lastname and accountnumber)
			Account ca1 = new Current_Account("james", "jony", 23234567,34222);
			Account ca2 = new Current_Account("Jhon", "Smith", 12334567,23456);

			// SavigsAccount (firstname lastname and account number)

		    Account sa1 = new Savings_Account("meurphy", "methew", 23456789,95363);
		    Account sa2 = new Savings_Account("jimyy", "smith", 2345986,34567);



			Account.Add(ca1);
			Account.Add(ca2);
			Account.Add(sa1);
			Account.Add(sa2);
			UpdatelistBox(accounts);//Call methos to display
		}

		private void UpdatelistBox(List<Account> accounts)
		{
			throw new NotImplementedException();
		}

		private void UpdatelistBox(Account account)
		{
			throw new NotImplementedException();
		}

		// Update field when an Account is selected
		private void LbxName__SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Account Selected = LbxName__SelectionItem as Account;

			if (Selected != null)
			{
				tblFN.Text = Selected.FirstName;
				tblLN.Text = Selected.LastName;

				//for current account

				if (Selected is Current_Account)
				{
					Current_Account ca = Selected as Current_Account;
					tblB.Text = ca.ToString();

					tbxTA.Clear();

					cbhCA.IsChecked = true;

				}
			}
			// for savings account
			else if (Selected is Savings_Account)
			{
				Savings_Account sa = Selected as Savings_Account;

				tbxTA.Clear();

				cbhSA.IsChecked = true;

			}
		}
	}
}

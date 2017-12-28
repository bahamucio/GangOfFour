using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Facade' class
	/// </summary>
	public class Mortage
	{
		private Bank _bank = new Bank();
		private Loan _loan = new Loan();
		private Credit _credit = new Credit();

		public bool IsEligible(Customer c, int amount)
		{
			Console.WriteLine("{0} applies for {1:C} loan\n", c.Name, amount);

			bool eligible = true;

			// Check creditworthyness of applicant
			if(!_bank.HasSufficientSavings(c, amount))
				eligible = false;
			else if (!_loan.HasNoBadLoans(c))
				eligible = false;
			else if (!_credit.HasGoodCredit(c))
				eligible = false;

			return eligible;
		}
	}
}

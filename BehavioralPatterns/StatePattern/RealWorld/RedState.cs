using System;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteState' class
	/// <remarks>
	/// Red indicates that the account is overdrawn
	/// </remarks>
	/// </summary>
	public class RedState : State
	{
		private double _serviceFee;

		public RedState(State state)
		{
			balance = state.Balance;
			account = state.Account;
			Initialize();
		}

		private void Initialize()
		{
			// Should come from datasource
			interest = 0.0;
			lowerLimit = -100.0;
			upperLimit = 0.0;
			_serviceFee = 15.00;
		}

		public override void Deposit(double amount)
		{
			balance += amount;
			StateChangeCheck();
		}

		public override void Withdraw(double amount)
		{
			amount = amount - _serviceFee;
			Console.WriteLine("No funds available for withdrawal!");
		}

		public override void PayInterest() { }

		private void StateChangeCheck()
		{
			if(balance > upperLimit)
			{
				account.State = new SilverState(this);
			}
		}
	}
}

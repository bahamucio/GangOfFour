using System;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteState' class
	/// <remarks>
	/// Silver indicates an non-interest bearing state
	/// </remarks>
	/// </summary>
	public class SilverState : State
	{
		// Overloaded constructors
		public SilverState(State state) : this(state.Balance, state.Account)
		{
		}

		public SilverState(double balance, Account account)
		{
			this.balance = balance;
			this.account = account;
			Initialize();
		}

		private void Initialize()
		{
			// Should come from datasource
			interest = 0.0;
			lowerLimit = 0.0;
			upperLimit = 1000.0;
		}

		public override void Deposit(double amount)
		{
			balance += amount;
			StateChangeCheck();
		}

		public override void Withdraw(double amount)
		{
			balance -= amount;
			StateChangeCheck();
		}

		public override void PayInterest()
		{
			balance += balance * interest;
		}

		private void StateChangeCheck()
		{
			if(balance < lowerLimit)
			{
				account.State = new RedState(this);
			}
			if(balance > upperLimit)
			{	
				account.State = new GoldState(this);
			}
		}
	}
}

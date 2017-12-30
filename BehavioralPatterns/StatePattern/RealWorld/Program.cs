using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// State Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Open a new account
			Account account = new Account("Jim Johnson");
			
			// Apply financial transactions
			account.Deposit(500.0);
			account.Deposit(300.0);
			account.Deposit(550.0);
			account.PayInterest();
			account.Withdraw(2000.0);
			account.Withdraw(1100.0);

			// Wait for user
			Console.ReadKey();
        }
    }
}

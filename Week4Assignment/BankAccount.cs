using System;
namespace Week4Assignment
{
	public class BankAccount
	{
        private string accountNumber;
        private decimal balance;
	        public BankAccount(string accountNumber)
		{
			this.accountNumber = accountNumber;
			this.balance = 0;
				}

		public string GetAccountNumber()
		{
			return accountNumber;
		}

		public decimal GetBalance()
		{
			return balance;
		}

		public void Deposit(decimal amount)
		{
			balance += amount;
		}
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
    }
}


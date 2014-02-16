using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public abstract class Account
    {
        public Customer Customer { get; private set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; private set; }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public virtual decimal CalcInterest(int months)
        {
            return months * this.InterestRate;
        }

        public void Deposit(decimal amount)
        {
            if (amount<=0)
            {
                throw new ArgumentException("Invalid amount for deposit");
            }
            this.Balance += amount;
        }       
    }
}

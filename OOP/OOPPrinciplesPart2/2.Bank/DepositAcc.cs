using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class DepositAcc:Account,IWithdraw
    {
        private const decimal maxBalanceForDiscount = 1000;


        public DepositAcc(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }        

        public override decimal CalcInterest(int months)
        {
            if (this.Balance>0 && this.Balance<=maxBalanceForDiscount)
            {
                return 0;
            }
            return base.CalcInterest(months);
        }

        public void WithDraw(decimal amount)
        {
            if (amount>this.Balance)
            {
                throw new ArgumentException("Not enough funds");
            }
            this.Balance -= amount;
        }
    }
}

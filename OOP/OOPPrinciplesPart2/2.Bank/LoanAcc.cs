using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class LoanAcc:Account
    {
        private const int monthsDiscountIndividuals = 3;
        private const int monthsDiscountCompanies = 2;

        public LoanAcc(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }                      

        public override decimal CalcInterest(int months)
        {
            if (this.Customer is Individual)
            {
                months -= monthsDiscountIndividuals;
            }

            if (this.Customer is Company)
            {
                months -= monthsDiscountCompanies;
            }

            if (months<=0)
            {
                throw new ArgumentException("Invalid number of months");
            }
            return base.CalcInterest(months);            
        }
    }
}

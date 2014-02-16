using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class MortgageAcc:Account
    {
        private const int monthsDiscountIndividuals = 6;
        private const int monthDiscountCompanies = 12;

        public MortgageAcc(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        

        public override decimal CalcInterest(int months)
        {
            if (months < 36)
            {
                throw new ArgumentException("Mortgage credit for less than 3 years? I doubt it.");
            }
            if (this.Customer is Company)
            {
                return (0.5m * monthDiscountCompanies * this.InterestRate) + (months - monthDiscountCompanies) * this.InterestRate;
            }

            if (this.Customer is Individual)
            {
                return (months-monthsDiscountIndividuals)*this.InterestRate;
            }
            return base.CalcInterest(months);
        }
    }
}

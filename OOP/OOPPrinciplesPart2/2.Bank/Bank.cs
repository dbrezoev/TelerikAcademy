using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class Bank
    {
        private List<Account> accounts;
        private List<Customer> customers;

        public List<Account> Accounts
        {
            get
            {
                return new List<Account>(this.accounts);
            }
            set
            {
                this.accounts = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return new List<Customer>(this.customers);
            }
            set
            {
                this.customers = value;
            }
        }

    }
}

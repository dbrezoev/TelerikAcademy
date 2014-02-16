using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Customer pesho = new Individual("Pesho");
            Customer telerik = new Company("Telerik");
            Customer gosho = new Individual("Gosho");
            Customer remax = new Company("Re/Max");
            b.Customers = new List<Customer>
            {
               pesho,
               telerik,
               gosho,
               remax
            };

            Account peshoAcc = new DepositAcc(pesho, 100, 3);
            Account telerikAcc = new MortgageAcc(telerik, 80000, 6);
            Account goshoAcc = new MortgageAcc(gosho, 450, 3);
            Account remaxAcc = new LoanAcc(remax, 90000, 7);
            b.Accounts = new List<Account>
            {
               peshoAcc,
               telerikAcc,
               goshoAcc,
               remaxAcc
            };


            //pesho operating
            Console.WriteLine("Pesho has {0} before deposit.",peshoAcc.Balance);

            peshoAcc.Deposit(50);
            Console.WriteLine("Now Pesho has {0} in his account",peshoAcc.Balance);

            (peshoAcc as DepositAcc).WithDraw(150);
            Console.WriteLine(peshoAcc.Balance);

            //calculating interest
            Console.WriteLine(peshoAcc.CalcInterest(7));

            Console.WriteLine(telerikAcc.CalcInterest(60));

            Console.WriteLine(goshoAcc.CalcInterest(50));                        
        }
    }
}

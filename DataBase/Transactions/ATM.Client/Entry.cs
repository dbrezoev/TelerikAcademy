using ATM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Models;
using System.Data.Entity;

namespace ATM.Client
{
    public class Entry
    {
        private const string Pin = "80801";
        private const string CardNumber = "123";
        private const decimal MoneyToWithdraw = 100;
        static void Main()
        {
            
            using (var db = new ATMSystemContext())
            {
                InsertSampleData(db);
                WithdrawMoney(Pin, CardNumber, MoneyToWithdraw, db);
            }            
        }

        private static void WithdrawMoney(string pin, string cardNumber, decimal money, ATMSystemContext dbContext)
        {
            try
            {
                var account = dbContext.CardAccounts.Where(a => a.CardPIN == pin && a.CardNumber == cardNumber && a.CardCash >= money);
                account.First().CardCash -= money;
                Console.WriteLine("Transaction successfull.");


                var transactionLog = new TransactionHistory()
                {
                    CardNumber = cardNumber,
                    Amount = money,
                    TransactionDate = DateTime.Now,
                };

                dbContext.TransactionHistories.Add(transactionLog);

                dbContext.SaveChanges();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Operation Failed.");           
            }
        }    
        
        private static void InsertSampleData(ATMSystemContext context)
        {
            var account = new CardAccount()
            {
                CardCash = 300,
                CardNumber = "123",
                CardPIN = "80801",
            };

            context.CardAccounts.Add(account);

            var account2 = new CardAccount()
            {
                CardCash = 350,
                CardNumber = "1234",
                CardPIN = "80802",
            };

            context.CardAccounts.Add(account2);

            var account3 = new CardAccount()
            {
                CardCash = 400,
                CardNumber = "1235",
                CardPIN = "80803",
            };

            context.CardAccounts.Add(account3);
            context.SaveChanges();
        }
    }
}

namespace ATM.Data.Migrations
{
    using ATM.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ATM.Data.ATMSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ATM.Data.ATMSystemContext";
        }

        protected override void Seed(ATM.Data.ATMSystemContext context)
        {

            //var account = new CardAccount()
            //{
            //    CardCash = 300,
            //    CardNumber = "123",
            //    CardPIN = "80801",
            //};

            //context.CardAccounts.Add(account);

            //var account2 = new CardAccount()
            //{
            //    CardCash = 350,
            //    CardNumber = "1234",
            //    CardPIN = "80802",
            //};

            //context.CardAccounts.Add(account2);

            //var account3 = new CardAccount()
            //{
            //    CardCash = 400,
            //    CardNumber = "1235",
            //    CardPIN = "80803",
            //};

            //context.CardAccounts.Add(account3);
            //context.SaveChanges();
        }
    }
}

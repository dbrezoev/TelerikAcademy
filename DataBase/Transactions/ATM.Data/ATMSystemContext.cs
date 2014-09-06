using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ATM.Models;
using ATM.Data.Migrations;

namespace ATM.Data
{
    public class ATMSystemContext : DbContext
    {
        public ATMSystemContext() :
            base("ATMConnection")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ATMSystemContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMSystemContext, Configuration>());
        }

        public IDbSet<CardAccount> CardAccounts { get; set; }

        public IDbSet<TransactionHistory> TransactionHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Customer
    {
        public string Name;
        public Customer(string name)
        {
            Name = name;   
        }
        public Statement GetLatestStatements()
        {
            var dateTime = DateTime.Now;
            return GetStatements(dateTime.Year, dateTime.Month - 1);
        }

        public Statement GetStatements(int year, int month)
        {
            return new Statement();
        }

        public Transaction GetTransaction(Transaction transyboi)
        {
            return transyboi
        }
    }
}

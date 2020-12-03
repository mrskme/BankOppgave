using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Account
    {
        public Customer Customer;
        public readonly string AccountType;
        public List<Transaction> Listy;
        public decimal Balance { get; set; }

        public Account(Customer customer, string accountType)
        {
            Customer = customer;
            AccountType = accountType;
        }

        public void AddTransaction(decimal amount)
        {
            Listy.Add(new Transaction(amount, "test", DateTime.Now));
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public Statement GetLatestStatement()
        {
            var dateTime = DateTime.Now;
            return GetStatement(dateTime.Year, dateTime.Month - 1);
        }

        public Statement GetStatement(int year, int month)
        {

            return null;
        }
    }
}

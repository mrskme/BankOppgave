using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Bank
    {
        public Customer CreateCustomer(string terje)
        {
            return new Customer(terje);
        }

        public Account CreateAccount(Customer customer, string accountType)
        {
            return new Account(customer, accountType);
        }

        public void Transfer(Customer customer, Account account1, Account account2, decimal amount)
        {
            // vi sender med kunde. Hvis kunden ikke eier fra-konto => feil
            if (customer == account1.Customer)
            {
                if (account1.Balance >= amount)
                {
                    account1.Balance -= amount;
                    account2.Balance += amount;
                    account2.AddTransaction(amount);
                }
            }
        }
    }
}

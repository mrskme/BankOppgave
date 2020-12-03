using System;

namespace BankOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var customer = bank.CreateCustomer("Terje");
            var account1 = bank.CreateAccount(customer, "Brukskonto 1");

            account1.Deposit(1000m);
            var account2 = bank.CreateAccount(customer, "Sparekonto 1");
            bank.Transfer(customer, account1, account2, 700m);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);

            var statement1 = account1.GetLatestStatement();
            var statement2 = account2.GetStatement(2020, 3);
            var statements1 = customer.GetLatestStatements();
            var statements2 = customer.GetStatements(2020, 3);

            Console.WriteLine("Kontoutskrift 1");
            foreach (var transaction in statement1.Transactions)
            {
                Console.Write(transaction.Amount);
                Console.Write(transaction.Date);
                Console.Write(transaction.Text);
            }
        }
    }
}

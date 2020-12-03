using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Statement
    {
        public IEnumerable<Transaction> Transactions { get; }

        public Statement(IEnumerable<Transaction> transactions)
        {
            Transactions = transactions;
        }
    }
}

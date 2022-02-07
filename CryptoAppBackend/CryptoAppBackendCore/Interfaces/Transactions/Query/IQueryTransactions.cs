using CryptoAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Interfaces.Transactions
{
    public interface IQueryTransactions
    {
        ICollection<Transaction> GetAllTransactions();
        ICollection<Transaction> GetAllTransactionsFrom(string AdressFrom);
        ICollection<Transaction> GetAllTransactionsTo(string AdressTo);
        ICollection<Transaction> GetAllTransactionsSinceSpecificDate(DateTime date);
        Transaction GetTransactionById(string Id);
    }
}

using CryptoAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Interfaces.Transactions
{
    interface IQueryTransactions
    {
        Task<IQueryable<Transaction>> GetAllTransactions();
        Task<Transaction> GetTransaction();
    }
}

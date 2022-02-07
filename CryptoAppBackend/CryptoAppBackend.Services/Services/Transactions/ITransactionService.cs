using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services.Services
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();
    }
}

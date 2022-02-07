using System.Collections.Generic;

namespace CryptoAppBackend.Services.Services
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();
    }
}

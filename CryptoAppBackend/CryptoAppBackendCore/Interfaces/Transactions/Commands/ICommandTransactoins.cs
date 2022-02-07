using CryptoAppBackend.Models;
using System.Threading.Tasks;

namespace CryptoAppBackend.Interfaces.Transactions.Commands
{
    interface ICommandTransactoins
    {
        Task<bool> PostTransaction(Transaction transaction);   
    }
}

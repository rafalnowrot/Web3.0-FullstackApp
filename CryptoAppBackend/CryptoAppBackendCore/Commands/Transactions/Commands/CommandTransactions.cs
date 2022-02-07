using CryptoAppBackend.Interfaces.Transactions.Commands;
using CryptoAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Core.Commands.Transactions.Commands
{
    class CommandTransactions : ICommandTransactoins
    {
        public Task<bool> PostTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}

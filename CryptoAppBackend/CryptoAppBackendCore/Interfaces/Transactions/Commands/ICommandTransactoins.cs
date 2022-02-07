using CryptoAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Interfaces.Transactions.Commands
{
    interface ICommandTransactoins
    {
        Task<bool> PostTransaction(Transaction transaction);   
    }
}

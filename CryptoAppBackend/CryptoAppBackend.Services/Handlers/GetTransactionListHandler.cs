using CryptoAppBackend.Services.Requests;
using CryptoAppBackend.Services.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services.Handlers
{
    public class GetTransactionListHandler : IRequestHandler<GetTransactionsList, List<Transaction>>
    {

        public Task<List<Transaction>> Handle(GetTransactionsList request, CancellationToken cancellationToken)
        {
            ITransactionService _transactionService = new TransactionService();

            return Task.FromResult(_transactionService.GetAllTransactions());
        }
    }
}

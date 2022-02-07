using CryptoAppBackend.Services.Requests;
using CryptoAppBackend.Services.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace CryptoAppBackend.Services.Handlers
{
    public class GetTransactionListHandler : IRequestHandler<GetTransactionsList, List<Transaction>>
    {

        public Task<List<Transaction>> Handle(GetTransactionsList request, CancellationToken cancellationToken)
        {
            ITransactionService _transactionService = new TransactionService();

            var dd = _transactionService.GetAllTransactions();

            return Task.FromResult(_transactionService.GetAllTransactions());
        }
    }
}

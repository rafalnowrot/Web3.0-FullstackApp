using CryptoAppBackend.Core.Commands.Transactions.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CryptoAppBackend.Interfaces.Transactions;
using CryptoAppBackend.Services.Mapper;

namespace CryptoAppBackend.Services.Services
{
    public class TransactionService: ITransactionService
    {
        private readonly IMapper mapper;

        public TransactionService()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            mapper = mappingConfig.CreateMapper();
        }

        public List<Transaction> GetAllTransactions()
        {
            IQueryTransactions _query = new QueryTransactions();

            var transactions = _query.GetAllTransactions().ToList();

            List<Transaction> transactionsForResponse = mapper.Map<List<Transaction>>(transactions);

            return transactionsForResponse;
        }

    }
}

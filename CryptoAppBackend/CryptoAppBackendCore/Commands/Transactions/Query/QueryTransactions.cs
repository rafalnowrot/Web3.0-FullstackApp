using CryptoAppBackend.Interfaces.Transactions;
using CryptoAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;

namespace CryptoAppBackend.Core.Commands.Transactions.Query
{
    public class QueryTransactions : IQueryTransactions
    {
        public ICollection<Transaction> GetAllTransactions()
        {
            string sql = " SELECT TransactionID ,AdressFrom ,AdressTo ,LocationByIP ,Country ,IsFirstAdressTransaction ,TransactionDate FROM[dbo].[Transactions]";
            ICollection<Transaction> transactions;

            using (var connection = new SqlConnection("data source=DESKTOP-4LM8G0M;initial catalog=CryptoDB;trusted_connection=true"))
            {
                connection.Open();

                transactions = connection.Query<Transaction>(sql).ToList();
            }

            return transactions;
        }

        public ICollection<Transaction> GetAllTransactionsFrom(string AdressFrom)
        {
            throw new NotImplementedException();
        }

        public ICollection<Transaction> GetAllTransactionsSinceSpecificDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public ICollection<Transaction> GetAllTransactionsTo(string AdressTo)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionById(string Id)
        {
            string sql = $" SELECT TransactionID, AdressFrom, AdressTo, LocationByIP, Country, IsFirstAdressTransaction, TransactionDate FROM[dbo].[Transactions] where TransactionID = {Id}";
            Transaction transaction;

            using (var connection = new SqlConnection("data source=DESKTOP-4LM8G0M;initial catalog=CryptoDB;trusted_connection=true"))
            {
                connection.Open();

                transaction = connection.Query<Transaction>(sql).First();
            }

            return transaction;
        }
    }
}


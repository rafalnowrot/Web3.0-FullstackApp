using CryptoAppBackend.Core.Interfaces.EtheriumFakeData.Query;
using CryptoAppBackend.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CryptoAppBackend.Core.Commands.EtheriumFakeData.Query
{
    public class QueryEtheriumData : IQueryEtheriumData
    {
        public ICollection<EtheriumData> GetAllData()
        {
            string sql = " SELECT [ID] ,[Price], [TransactionFees] ,[DateOfPriceChecking] FROM[dbo].[EthereumFakeData]";

            ICollection<EtheriumData> etheriumData;

            using (var connection = new SqlConnection("data source=DESKTOP-4LM8G0M;initial catalog=CryptoDB;trusted_connection=true"))
            {
                connection.Open();

                etheriumData = connection.Query<EtheriumData>(sql).ToList();
            }

            return etheriumData;
        }

        public EtheriumData GetDataByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public EtheriumData GetDataById(string Id)
        {
            throw new NotImplementedException();
        }
    }
}

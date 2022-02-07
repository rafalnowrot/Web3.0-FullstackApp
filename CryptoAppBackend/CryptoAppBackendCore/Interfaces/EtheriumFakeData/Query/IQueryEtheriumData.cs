using System;
using System.Collections.Generic;
using CryptoAppBackend.Models;

namespace CryptoAppBackend.Core.Interfaces.EtheriumFakeData.Query
{
    public interface IQueryEtheriumData
    {
        ICollection<EtheriumData> GetAllData();
        EtheriumData GetDataById(string Id);
        EtheriumData GetDataByDate(DateTime date);
    }
}

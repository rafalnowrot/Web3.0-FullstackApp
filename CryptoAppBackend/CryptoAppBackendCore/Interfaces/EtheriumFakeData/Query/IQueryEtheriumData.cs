using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

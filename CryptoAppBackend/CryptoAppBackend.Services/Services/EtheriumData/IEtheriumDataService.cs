using System.Collections.Generic;

namespace CryptoAppBackend.Services.Services
{
    public interface IEtheriumDataService
    {
        List<EtheriumData> GetAllData();
    }
}

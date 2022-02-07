using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Core.Interfaces.Connection
{
    interface IConnectionDb
    {
        bool IsDatabaseExist();
    }
}

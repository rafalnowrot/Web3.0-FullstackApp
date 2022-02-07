using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Models
{
    public class EtheriumData
    {
        public int Id { get; set; }
        public decimal  Price { get; set; }
        public decimal  TransactionFees { get; set; }
        public DateTime  DateOfPriceChecking { get; set; }
    }
}

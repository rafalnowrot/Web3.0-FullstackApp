using System;

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

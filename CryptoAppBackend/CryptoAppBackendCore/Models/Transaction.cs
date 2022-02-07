using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string AdressFrom{ get; set; }
        public string AdressTo { get; set; }
        public string LocationByIP { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool IsFirstAdressTransaction { get; set; }
    }
}

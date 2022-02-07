using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string AdressFrom{ get; set; }
        public string AdressTo { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}

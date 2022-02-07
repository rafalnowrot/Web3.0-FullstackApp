using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services
{
    public class Transaction : IRequest<bool>
    {
        public int TransactionID { get; set; }
        public string AdressFrom { get; set; }
        public string AdressTo { get; set; }
        public string LocationByIP { get; set; }
        public bool IsFirstAdressTransaction { get; set; }
    }
}

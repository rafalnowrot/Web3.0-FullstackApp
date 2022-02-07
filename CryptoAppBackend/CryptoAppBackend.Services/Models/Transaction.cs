using MediatR;

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

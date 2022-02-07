using MediatR;
using System.Collections.Generic;

namespace CryptoAppBackend.Services.Requests
{
    public record GetTransactionsList(): IRequest<List<Transaction>>;
}

using MediatR;
using System.Collections.Generic;

namespace CryptoAppBackend.Services.Requests
{
    public record GetEtheriumDataList() : IRequest<List<EtheriumData>>;
}

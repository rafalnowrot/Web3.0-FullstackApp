using CryptoAppBackend.Services.Requests;
using CryptoAppBackend.Services.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services.Handlers
{
    public class GetEtheriumDataListHandler : IRequestHandler<GetEtheriumDataList, List<EtheriumData>>
    {

        public Task<List<EtheriumData>> Handle(GetEtheriumDataList request, CancellationToken cancellationToken)
        {
            IEtheriumDataService etheroiumDataService = new EtheriumDataService();

            return Task.FromResult(etheroiumDataService.GetAllData());
        }
    }
}

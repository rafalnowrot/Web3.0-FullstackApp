using CryptoAppBackend.Services.Requests;
using CryptoAppBackend.Services.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services.Handlers
{
    public class GetEtheriumDataListHandler : IRequestHandler<GetEtheriumDataList, List<EtheriumData>>
    {

        public Task<List<EtheriumData>> Handle(GetEtheriumDataList request, CancellationToken cancellationToken)
        {
            IEtheriumDataService etheroiumDataService = new EtheriumDataService();

            var dd = etheroiumDataService.GetAllData();

            return Task.FromResult(etheroiumDataService.GetAllData());
        }
    }
}

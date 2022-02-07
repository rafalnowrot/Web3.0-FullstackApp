using AutoMapper;
using CryptoAppBackend.Core.Commands.EtheriumFakeData.Query;
using CryptoAppBackend.Core.Interfaces.EtheriumFakeData.Query;
using CryptoAppBackend.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services.Services
{
    public class EtheriumDataService : IEtheriumDataService
    {
        private readonly IMapper mapper;

        public EtheriumDataService()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            mapper = mappingConfig.CreateMapper();
        }


        public List<EtheriumData> GetAllData()
        {
            IQueryEtheriumData _query = new QueryEtheriumData();

            var etheriumDbData = _query.GetAllData().ToList();

            List<EtheriumData> etheriumData = mapper.Map<List<EtheriumData>>(etheriumDbData);

            return etheriumData;
        }
    }
}

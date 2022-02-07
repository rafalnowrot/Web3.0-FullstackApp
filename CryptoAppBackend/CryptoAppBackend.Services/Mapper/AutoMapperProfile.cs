using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CryptoAppBackend.Services;

namespace CryptoAppBackend.Services.Mapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Transaction, Transaction>());

            CreateMap<Transaction, CryptoAppBackend.Models.Transaction>()
               .ForMember(dest => dest.TransactionID,
                opt => opt.MapFrom(src => src.TransactionID))
               .ForMember(dest => dest.AdressFrom,
                opt => opt.MapFrom(src => src.AdressFrom))
               .ForMember(dest => dest.AdressTo,
                opt => opt.MapFrom(src => src.AdressTo))
                .ForMember(dest => dest.IsFirstAdressTransaction,
                opt => opt.MapFrom(src => src.IsFirstAdressTransaction))
                .ForMember(dest => dest.LocationByIP,
                opt => opt.MapFrom(src => src.LocationByIP));

            CreateMap<CryptoAppBackend.Models.Transaction, Transaction>()
               .ForMember(dest => dest.TransactionID,
                opt => opt.MapFrom(src => src.TransactionID))
               .ForMember(dest => dest.AdressFrom,
                opt => opt.MapFrom(src => src.AdressFrom))
                .ForMember(dest => dest.AdressTo,
                opt => opt.MapFrom(src => src.AdressTo))
                .ForMember(dest => dest.IsFirstAdressTransaction,
                opt => opt.MapFrom(src => src.IsFirstAdressTransaction))
                .ForMember(dest => dest.LocationByIP,
                opt => opt.MapFrom(src => src.LocationByIP));

            CreateMap<EtheriumData, CryptoAppBackend.Models.EtheriumData>()
               .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Price,
                opt => opt.MapFrom(src => src.Price))
               .ForMember(dest => dest.TransactionFees,
                opt => opt.MapFrom(src => src.TransactionFees));

            CreateMap<CryptoAppBackend.Models.EtheriumData, EtheriumData>()
               .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Price,
                opt => opt.MapFrom(src => src.Price))
               .ForMember(dest => dest.TransactionFees,
                opt => opt.MapFrom(src => src.TransactionFees));



        }
    }
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAppBackend.Services.Requests
{
    public record GetEtheriumDataList() : IRequest<List<EtheriumData>>;
}
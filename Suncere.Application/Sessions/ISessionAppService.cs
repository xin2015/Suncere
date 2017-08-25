﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Suncere.Sessions.Dto;

namespace Suncere.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
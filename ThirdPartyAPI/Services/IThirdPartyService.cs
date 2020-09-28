using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyAPI.Poco;

namespace ThirdPartyAPI.Services
{
    public interface IThirdPartyService
    {
        public Task<string> GotoGameAsync(TpInfo tpInfo);
    }
}

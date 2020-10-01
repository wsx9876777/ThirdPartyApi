using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThirdPartyAPI.Models;
using ThirdPartyAPI.Poco;
using ThirdPartyAPI.Services;

namespace ThirdPartyAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyController : ControllerBase
    {
        private readonly IThirdPartyService _thirdPartyService;

        public ThirdPartyController(
            IThirdPartyService thirdPartyService
            )
        {
            this._thirdPartyService = thirdPartyService;
        }
        [HttpGet]
        public async Task<ActionResult<ApiResult>> Get()
        {



            var result = new ApiResult();
            TpInfo tpInfo = new TpInfo()
            {
                GameType = "Ag"
            };
            var data = await _thirdPartyService.GotoGameAsync(tpInfo);
            result.Data = data;
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<ApiResult>> GotoGame(TpInfo tpInfo)
        {
            var result = new ApiResult();
           // var data = await _thirdPartyService.GotoGameAsync(tpInfo);
           // result.Data = data;
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Transfer()
        {
            var result = new ApiResult();
            return Ok(123);
        }

    }
}

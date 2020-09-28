using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyAPI.Models
{
    public class ApiResult
    {
        public ApiResult(bool success)
        {
            _Success = success;
        }
        public ApiResult():this(true)
        {
        }

        private bool _Success;

        public bool Success
        {
            get { return _Success; }
            set { _Success = value; }
        }

        public string Data { get; set; }
    }
}

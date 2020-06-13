﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Core.Interfaces
{
    public interface IHttpCallHandler
    {
        Task<KeyValuePair<int, string>> GeneralRequestAsync(string url, string method, string payload = null, ApiVersion api = ApiVersion.V5, string clientId = null, string accessToken = null);
        Task PutBytesAsync(string url, byte[] payload);
        Task<int> RequestReturnResponseCodeAsync(string url, string method, List<KeyValuePair<string, string>> getParams = null);
        Task<KeyValuePair<int, string>> CustomRequestAsync(string url, string method, HttpContent payload,
            ApiVersion api, string clientId, string accessToken);
    }
}

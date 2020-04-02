using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNetwork.Data
{
    public class TokenInfo
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("refreshToken")]
        public string refreshToken { get; set; }

        public TokenInfo(string token, string refreshToken)
        {
            Token = token;
            this.refreshToken = refreshToken;
        }

        public TokenInfo()
        {

        }
    }
}

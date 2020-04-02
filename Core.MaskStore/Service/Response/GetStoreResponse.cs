using MaskInfo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskInfo.Service.Response
{
    class GetStoreResponse
    {
        [JsonProperty("stores")]
        public List<Store> strores { get; set; }
    }
}

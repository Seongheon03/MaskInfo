using MaskInfo.Model;
using MaskInfo.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNetwork;

namespace MaskInfo.Service
{
    class StoreService
    {
        private const string PublicDataServerUrl = "https://8oi9s0nnth.apigw.ntruss.com/corona19-masks/v1";
        private const string JungMinServerUrl = "http://39.112.16.40";
        private NetworkManager networkManager = new NetworkManager();

        public async Task<GetStoreResponse> GetStoreByAddress(string address)
        {
            return await networkManager.GetResponse<GetStoreResponse>(PublicDataServerUrl + "/storesByAddr/json?address=" + address, RestSharp.Method.GET);
        }

        public async Task<List<Store>> GetDrugstore(string name)
        {
            return await networkManager.GetResponse<List<Store>>(JungMinServerUrl + "/drugstore?name=" + name, RestSharp.Method.GET);
        }

        public async Task<string> GetMasks(string code)
        {
            var resp = await networkManager.GetResponse<List<Store>>(JungMinServerUrl + "/masks?code=" + code, RestSharp.Method.GET);

            return resp[0].Remain_stat;
        }
    }
}

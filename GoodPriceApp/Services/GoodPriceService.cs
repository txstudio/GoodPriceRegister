using GoodPrice.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoodPriceApp.Services
{
    public interface IGoodPriceService
    {
        Task<IEnumerable<Good>> GetListAsync();

        Task<Good> GetAsync(int Id);
    }

    public class GoodPriceService : IGoodPriceService
    {
        private readonly HttpClient _client;

        public GoodPriceService(HttpClient client)
        {
            this._client = client;
            this._client.BaseAddress = new Uri("https://localhost:32770");
        }

        public async Task<IEnumerable<Good>> GetListAsync()
        {
            var _response = await this._client.GetAsync("/goodPrice");
            var _json = await _response.Content.ReadAsStringAsync();
            var _results = JsonConvert.DeserializeObject<IEnumerable<Good>>(_json);

            return _results;
        }

        public async Task<Good> GetAsync(int Id)
        {
            var _uri = string.Format("/goodPrice/{0}", Id);
            var _response = await this._client.GetAsync(_uri);
            var _json = await _response.Content.ReadAsStringAsync();
            var _result = JsonConvert.DeserializeObject<Good>(_json);

            return _result;
        }
    }
}

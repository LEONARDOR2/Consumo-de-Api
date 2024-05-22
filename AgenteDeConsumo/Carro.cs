using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agente
{
    internal class Carro
    {

        public int? id { get; set; }

        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public string? Preco { get; set; }

        public string? Ano { get; set; }



        public async Task<List<Carro>> ObterCarroAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7155/api/Carro", Method.Get);

            RestResponse response = await client.ExecuteGetAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)


                return JsonConvert.DeserializeObject<List<Carro>>
                  (response.Content);

            else

                return null;

        }


    }
}

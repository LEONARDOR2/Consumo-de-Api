
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Agente;

public class Produto
{
    public int id { get; set; }
    public string? marca { get; set; }
    public string? modelo { get; set; }
    public string? preco { get; set; }
    public string? Estoque { get; set; }




    public async Task<List<Produto>> ObterPodutosAsync()
{
    var client = new RestClient();
    var request = new RestRequest("https://localhost:7155/api/Produto", Method.Get);

    RestResponse response = await client.ExecuteGetAsync(request);

    if (response.StatusCode == System.Net.HttpStatusCode.OK)


        return JsonConvert.DeserializeObject<List<Produto>>
          (response.Content);

    else

        return null;

}

}
using Microsoft.AspNetCore.Mvc;
using Produtos.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Produtos.Controllers  
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET: api/<ProdutoController>
        [HttpGet]
        public IEnumerable<ProdutoModel> Get()
        {
           ProdutoModel produto = new ProdutoModel();

            produto.id = 1;
            produto.Marca = "ControlId";
            produto.Modelo  = "Idclass";
            produto.Preco = "R$ 2000";
            produto.Estoque = "100";
            yield return (produto);

            ProdutoModel produto1 = new ProdutoModel();

            produto1.id = 2;
            produto1.Marca = "Henry";
            produto1.Modelo = "Prsima adv";
            produto1.Preco = "R$ 2500";
            produto1.Estoque = "100";
            yield return (produto1);

            ProdutoModel produto2 = new ProdutoModel();

            produto2.id = 3;
            produto2.Marca = "Rwtech";
            produto2.Modelo = "Ipointline v2";
            produto2.Preco = "R$ 2200";
            produto2.Estoque = "100";
            yield return (produto2);

            ProdutoModel produto3 = new ProdutoModel();

            produto3.id = 4;
            produto3.Marca = "Rwtech";
            produto3.Modelo = "Blue v3";
            produto3.Preco = "R$ 2000";
            produto3.Estoque = "100";
            yield return (produto3);

            ProdutoModel produto4 = new ProdutoModel();
            produto4.id = 5;
            produto4.Marca = "Henry";
            produto4.Modelo = "Hexa adv";
            produto4.Preco = "R$ 2500";
            produto4.Estoque = "100";
            yield return (produto4);


            ProdutoModel produto5 = new ProdutoModel();
            produto5.id = 6;
            produto5.Marca = "Henry";
            produto5.Modelo = "Prsima J";
            produto5.Preco = "R$ 2000";
            produto5.Estoque = "100";
            yield return (produto5);

        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

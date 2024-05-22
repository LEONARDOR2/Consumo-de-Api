using Microsoft.AspNetCore.Mvc;
using Produtos.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Produtos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        // GET: api/<CarroController>
        [HttpGet]
        public IEnumerable<CarroModel> Get()
        {
            CarroModel carro = new CarroModel();

            carro.id = 1;
            carro.Marca = "Fiat";
            carro.Modelo = "Palio";
            carro.Preco = "R$ 20000";
            carro.Ano = "2011";
            yield return (carro);

            CarroModel carro1 = new CarroModel();

            carro1.id = 2;
            carro1.Marca = "Fiat";
            carro1.Modelo = "Cronos";
            carro1.Preco = "R$ 60000";
            carro1.Ano = "2019";
            yield return (carro1);

            CarroModel carro2 = new CarroModel();

            carro2.id = 3;
            carro2.Marca = "Bmw";
            carro2.Modelo = "X6";
            carro2.Preco = "R$ 700000";
            carro2.Ano = "2023";
            yield return (carro2);

            CarroModel carro3 = new CarroModel();

            carro3.id = 4;
            carro3.Marca = "Honda";
            carro3.Modelo = "Civic";
            carro3.Preco = "R$ 120000";
            carro3.Ano = "2020";
            yield return (carro3);

            CarroModel carro4 = new CarroModel();
            carro4.id = 5;
            carro4.Marca = "Ford";
            carro4.Modelo = "Fusion";
            carro4.Preco = "R$ 200000";
            carro4.Ano = "2021";
            yield return (carro4);


            CarroModel carro5 = new CarroModel();
            carro5.id = 6;
            carro5.Marca = "Renaut";
            carro5.Modelo = "Sandero";
            carro5.Preco = "R$ 85000";
            carro5.Ano = "2024";
            yield return (carro5);

        }

        // GET api/<CarroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
           return "value";
           
        }

        // POST api/<CarroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

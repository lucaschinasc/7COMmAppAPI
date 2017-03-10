using _7COMmAppApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _7COMmAppApi.Controllers
{
    
    public class PedidosController : ApiController
    {
        // GET api/<controller>
        public List<Pedido> Get()
        {
            return ListarPedidos();
        }

        public List<Pedido> ListarPedidos()
        {
            var retorno = new List<Pedido>();
            
            Pedido obj = new Pedido()
            {
                Id = 1,
                Data = DateTime.Now.ToShortDateString(),
                Titulo = "Pedido XPTO",
                Status = "Aprovado",
                TipoPagamento = "Boleto Bancário",
                DataPagamento = DateTime.Now.ToShortDateString(),
                Produtos = ListarProdutos(1)

            };

            retorno.Add(obj);

            obj = new Pedido()
            {
                Id = 2,
                Data = "20/02/2017",
                Titulo = "Pedido ABC",
                Status = "Pendente",
                TipoPagamento = "Boleto Bancário",
                DataPagamento = DateTime.Now.ToShortDateString(),
                Produtos = ListarProdutos(2)

            };

            retorno.Add(obj);


            return retorno;
        }

        public List<Produto> ListarProdutos(int tipo = 1)
        {
            var retorno = new List<Produto>();

            if (tipo == 1)
            {
                Produto obj = new Produto()
                {
                    Id = 1,
                    Descricao = "Produto XPTO foi pedido etc etc",
                    Valor = 25,
                    SrcImagem = "https://openclipart.org/image/2400px/svg_to_png/211800/matt-icons_package.png"
                };

                retorno.Add(obj);

                obj = new Produto()
                {
                    Id = 2,
                    Descricao = "Prod2 do XPTO",
                    Valor = 47,
                    SrcImagem = "http://dreamatico.com/data_images/gift/gift-5.jpg"
                };

                retorno.Add(obj);
            }
            else
            {
                Produto obj = new Produto()
                {
                    Id = 3,
                    Descricao = "Produto ABC foi pedido etc etc",
                    Valor = 150,
                    SrcImagem = "https://openclipart.org/image/800px/svg_to_png/272603/Logo-modification-2017021128-remix-3.png"
                };

                retorno.Add(obj);

                obj = new Produto()
                {
                    Id = 4,
                    Descricao = "Produto ABC2 teste teste...",
                    Valor = 250,
                    SrcImagem = "https://openclipart.org/image/800px/svg_to_png/272516/Bingual-Boy-Girl.png"
                };

                retorno.Add(obj);
            }
            return retorno;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
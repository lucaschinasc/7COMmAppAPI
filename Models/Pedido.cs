using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7COMmAppApi.Models
{
    public class Pedido
    {

        public int Id { get; set; }
        public string Data { get; set; }
        public string Titulo { get; set; }

        public string TipoPagamento { get; set; }

        public string DataPagamento { get; set; }

        public List<Produto> Produtos { get; set; }

        public string Status { get; set; }

        public string StatusPagamento { get; set; }

    }
}
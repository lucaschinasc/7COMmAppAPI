using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7COMmAppApi.Models
{
    public class Produto
    {

        public int Id { get; set; }
      
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public string SrcImagem { get; set; }
        
    }
}
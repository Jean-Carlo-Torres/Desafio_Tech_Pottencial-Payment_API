using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paymentapi.Models
{
    public class ItemVenda
    {
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
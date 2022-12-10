using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public string Cidade { get; set; }
        public List<Venda> Vendas { get; set; }


    }
}

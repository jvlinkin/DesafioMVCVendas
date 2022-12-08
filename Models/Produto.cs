using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Desc_Produto { get; set; }
        public float Vlr_Unitario { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Venda> Vendas { get; set; }




    }
}

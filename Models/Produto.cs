using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Descricao { get; set; }
        public float Vlr_Unitario { get; set; }
        public virtual List<Venda> Vendas { get; set; }




    }
}

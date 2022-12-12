using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        public Usuario Usuario { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public int QtdProduto { get; set; }
        public float VlrUnitarioProduto { get; set; }
        public DateTime DtHoraVenda { get; set; }
        public float VlrTotalVenda { get; set; }



    }
}

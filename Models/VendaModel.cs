using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Models
{
    public class VendaModel
    {
        public int id_venda { get; set; }
        public int id_cliente { get; set; }
        public int id_produto { get; set; }
        public int qtd_produto { get; set; }
        public int vlr_unitario_venda { get; set; }
        public int dt_hora_venda { get; set; }
        public float vlr_total_venda { get; set; }

        
    }
}

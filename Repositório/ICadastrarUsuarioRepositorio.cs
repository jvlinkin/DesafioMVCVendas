using DesafioVendasClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Repositório
{
   public interface ICadastrarUsuarioRepositorio
    {
        Usuario Cadastrar(Usuario usuario);
    }
}

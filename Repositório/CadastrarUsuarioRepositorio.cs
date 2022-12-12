using DesafioVendasClientes.Data;
using DesafioVendasClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Repositório
{
    public class CadastrarUsuarioRepositorio : ICadastrarUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;

        public CadastrarUsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public Usuario Cadastrar(Usuario usuario)
        {
            usuario.Nome = usuario.Nome.ToUpper();
            usuario.Email = usuario.Email.ToLower();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();

            return usuario;
            
        }

        
    }
}

using DesafioVendasClientes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Models
{
    public class CadastrarUsuarioModel
    {
        public int UsuarioID { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a data de nascimento")]
        public DateTime Data_Nascimento { get; set; }
        [Required(ErrorMessage = "Digite o email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme a senha do usuário.")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmarSenha { get; set; }
        
        [Required(ErrorMessage = "Selecione o perfil do usuário")]
        public PerfilEnum Perfil { get; set; }
        public List<Venda> Vendas { get; set; }


    }
}

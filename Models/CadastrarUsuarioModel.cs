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
        [Required(ErrorMessage = "Nome de usuário inválido.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Data de nascimento inválida.")]
        public DateTime Data_Nascimento { get; set; }
        [Required(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha inválida.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirmação de senha inválida..")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem. Favor verificar.")]
        public string ConfirmarSenha { get; set; }
        
        [Required(ErrorMessage = "Perfil de usuário inválido.")]
        public PerfilEnum Perfil { get; set; }
        


    }
}

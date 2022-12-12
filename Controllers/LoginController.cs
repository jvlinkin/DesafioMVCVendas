using DesafioVendasClientes.Models;
using DesafioVendasClientes.Repositório;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICadastrarUsuarioRepositorio _cadastrarUsuarioRepositorio;
        public LoginController(ICadastrarUsuarioRepositorio cadastrarUsuarioRepositorio)
        {
            _cadastrarUsuarioRepositorio = cadastrarUsuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(CadastrarUsuarioModel cadastrarUsuarioModel,
                                              Usuario usuario)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(cadastrarUsuarioModel);
                }

                //Chamar o método do repositório
                _cadastrarUsuarioRepositorio.Cadastrar(usuario);
                TempData["SuccessMessage"] = "Usuário cadastrado com sucesso";
                return RedirectToAction("Index", "Login");

            }
            catch (Exception erro)
            {
                TempData["ErrorMessage"] = $"Ops, ocorreu um erro. Detalhes do erro: {erro}";
                return RedirectToAction("CadastrarUsuario");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DestinoCerto.Models;
using Microsoft.AspNetCore.Http;

namespace DestinoCerto.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Usuario novoUsuario)
        {
            UsuarioBanco user =  new UsuarioBanco();
            user.Insert(novoUsuario);
            ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            return View();
        }
        public IActionResult Lista()
        {
            UsuarioBanco user = new UsuarioBanco();
            List<Usuario> lista = user.Query();
            return View(lista);
        }
    }
}
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
            if (HttpContext.Session.GetInt32("idUsuario") == null || HttpContext.Session.GetInt32("tipoUsuario") != 0)
            {
                return RedirectToAction("Login");
            }
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
            if (HttpContext.Session.GetInt32("idUsuario") == null || HttpContext.Session.GetInt32("tipoUsuario") != 0)
            {
                return RedirectToAction("Login");
            }
            UsuarioBanco user = new UsuarioBanco();
            List<Usuario> lista = user.Query();
            return View(lista);
        }
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            Usuario usuarioSessao = usuarioBanco.QueryLogin(usuario);

            if(usuarioSessao != null)
            {
                ViewBag.Mensagem = "Você está logado!";
                HttpContext.Session.SetInt32("idUsuario", usuarioSessao.IdUser);
                HttpContext.Session.SetString("nomeUsuario", usuarioSessao.NomeUser);
                HttpContext.Session.SetInt32("tipoUsuario", usuarioSessao.Tipo);


                return Redirect("Cadastro");
            } else {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

    }
}
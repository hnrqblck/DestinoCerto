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
    public class PacoteController : Controller
    {
        public IActionResult Cadastro()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Pacote novoPacote)
        {
            PacoteBanco pack =  new PacoteBanco();
            int id = (int)HttpContext.Session.GetInt32("idUsuario");
            pack.Insert(novoPacote, id);
            ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            return View();
        }
        public IActionResult Lista()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            PacoteBanco pack = new PacoteBanco();
            List<Pacote> lista = pack.Query();
            return View(lista);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuario");
        }
    }
}
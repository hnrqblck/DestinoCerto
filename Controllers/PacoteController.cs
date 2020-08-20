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
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Pacote novoPacote)
        {
            PacoteBanco pack =  new PacoteBanco();
            pack.Insert(novoPacote);
            ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            return View();
        }
    }
}
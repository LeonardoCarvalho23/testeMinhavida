using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeVacina.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Inicio()
        {
            ViewBag["Agendamentos"] = 0;
            return View();
        }

        public IActionResult Agenda() {
            return View();
        }

        public JsonResult ObterAgenda()
        {
            return Json("");
        }

        public JsonResult CadastrarNovoAgendamento() {
            return Json("");
        }
    }
}
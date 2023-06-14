using ControleProcedure.DATA.Models;
using ControleProcedure.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControleProcedure.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisplayTemplatesEditorTemplates.Models;

namespace DisplayTemplatesEditorTemplates.Controllers
{
    public class HomeController : Controller
    {
        DbContext contexto = new DbContext();
        
        public IActionResult Index()
        {
            var cli = contexto.ListClientes;
            return View( cli );
        }

        public IActionResult Privacy()
        {
            var cli = contexto.ListClientes;
            return View(cli);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

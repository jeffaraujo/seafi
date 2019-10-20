using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Web.Seafi.Models;

namespace Web.Seafi.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private SeafiContext _context;
        

        public LoginController(ILogger<LoginController> logger, SeafiContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Login,Senha")] Usuario usuario)
        {

            var user = _context.Usuarios.FirstOrDefault(u => u.Login == usuario.Login && u.Senha == usuario.Senha);

            if(user != null)
            {
                HttpContext.Session.SetString("Nome", user.Nome);        
                return RedirectToAction("Index", "Mapa");
            }
            return Error();
                
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

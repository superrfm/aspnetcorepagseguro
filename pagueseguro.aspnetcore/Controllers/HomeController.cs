using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pagueseguro.aspnetcore.Models;
using Uol.PagSeguro.Domain;
using Uol.PagSeguro.Resources;

namespace pagueseguro.aspnetcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult ObterConfiguracoes() {

            AccountCredentials credentials = PagSeguroConfiguration.Credentials(false);
            return Ok(credentials);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataMicrosService1.Controllers
{
    public class ProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

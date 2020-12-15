using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CloakedContent.Controllers
{
    public class SiteManagmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADAGroup.EIG.UI.Controllers
{
    public class EIGController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(string groupId)
        {
            return View();
        }
    }
}
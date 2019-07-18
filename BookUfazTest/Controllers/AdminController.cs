using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUfazTest.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public AdminController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Core.Models;

namespace ProyectoLibreria.Controllers
{


    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

    }
}

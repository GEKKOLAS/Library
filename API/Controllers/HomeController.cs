﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;

namespace ProyectoLibreria.Controllers
{
    

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ClaimsPrincipal claimsUser = HttpContext.User;
            string nombreUsuario = "";
            string fotoPerfil = "";

            if (claimsUser.Identity != null && claimsUser.Identity.IsAuthenticated)
            {
                nombreUsuario = claimsUser.Claims.Where(c => c.Type == ClaimTypes.Name)
                    .Select(c => c.Value).SingleOrDefault() ?? "";

                fotoPerfil = claimsUser.Claims.Where(c => c.Type == "FotoPerfil")
                    .Select(c => c.Value).SingleOrDefault() ?? "";

            }

            ViewData["nombreUsuario"] = nombreUsuario;
            ViewData["fotoPerfil"] = fotoPerfil;
            return View();
        }

        
    }
}
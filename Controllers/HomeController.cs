﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Login_Registro_usando_MVC_y_JavaScript_Martinez_Marcos_Palachi_Thiago.Models;

namespace TP9_Login_Registro_usando_MVC_y_JavaScript_Martinez_Marcos_Palachi_Thiago.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Login");
    }

    public IActionResult Account(string Nombre, string Contraseña,int Telefono, string Ciudad,int DNI)
    {
        
        if (BD.IniciarSesion(Nombre,Contraseña,Telefono,Ciudad,DNI) = null )
        {
            return View("Login");
        }
        return View("Principal");
    }

[HttpPost]
    public IActionResult ObtnerContraseña(string Nombre)
    {
        BD.ObtnerContraseña(Nombre);
        return RedirectToAction("Account");
    }


[HttpPost]
    public IActionResult CrearUsuario(string Nombre, string Contraseña,int Telefono, string Ciudad,int DNI)
    {
        BD.CrearUsuario(Nombre,Contraseña,Telefono,Ciudad,DNI);
        return View("Principal");
    }




   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
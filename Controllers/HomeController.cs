using System.Diagnostics;
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

    public IActionResult Registro()
    {
        return View("Registrarse");     
    }

    public IActionResult Principal(Usuario us1)
    {
        return View("Principal");
    }

    public IActionResult OlvideContraseña()
    {
        return View("Olvidar contraseña");
    }
[HttpPost]
    public IActionResult Account(string Nombre, string Contraseña)
    {
        ViewBag.us1 = BD.IniciarSesion(Nombre,Contraseña);
        if (ViewBag.us1 == null )
        {
            return View("Login");
        }
        return RedirectToAction("Principal",new{us1 = ViewBag.us1});
    }



[HttpPost]
    public IActionResult ObtnerContraseña(int DNI)
    {
        ViewBag.Contraseña = BD.ObtnerContraseña(DNI);
        
        return View("Olvidar contraseña");
    }


[HttpPost]
    public IActionResult CrearUsuario(string Nombre, string Contraseña,int Telefono, string Ciudad,int DNI)
    {
        ViewBag.us1 = BD.CrearUsuario(Nombre,Contraseña,Telefono,Ciudad,DNI);
        return View("Principal", new {us1 = ViewBag.us1});
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

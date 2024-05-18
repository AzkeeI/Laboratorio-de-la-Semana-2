using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult TeacherList()
    {
        return View();
    }public IActionResult DegreeList()
    {
        DegreeModel Carrer = new DegreeModel();
        Carrer.NombreCarrer = "Ingenieria en Desarrollo Software";
        Carrer.NombreT = "Alenajdro Sanchez";


        Carrer.NombreCarrer2 = "Licenciatura en Computacion";
        Carrer.NombreT2 = "Mario Alberto";
        
        

        return View(Carrer);
    }

      public IActionResult StudentList()
    {
        StudentModel Alumno = new StudentModel();
        Alumno.Nombre = "Julian Macias";
        Alumno.Carrera = "Ing en Desarrollo Software";
        return View(Alumno);
    }
  

   

    public IActionResult Profesores()
    {
        TeacherModel Teacher = new TeacherModel();
        Teacher.NombreT = "Alenajdro Sanchez";
        Teacher.MateriaT = "Biologia";

        Teacher.NombreT2 = "Mario Alberto";
        Teacher.MateriaT2 = "POO2";
        return View(Teacher);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

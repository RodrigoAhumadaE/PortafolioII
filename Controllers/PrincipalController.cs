using Microsoft.AspNetCore.Mvc;
namespace PortafolioI.Controllers;
public class PrincipalController : Controller{  

  [HttpGet("")]
  public ViewResult Index(){
    return View("Index");
  }

  [HttpGet("/proyectos")]
  public ViewResult Proyectos(){
    return View("Proyectos");
  }

  [HttpGet("/contacto")]
  public string Contacto(){
    return "Aquí puedes contactarme!!";
  }
}
using dotnet_core_webapi.Models;
using dotnet_core_webapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_webapi.Controllers;

[ApiController]
[Route("/")]
public class IndexController : ControllerBase
{
  public IndexController()
  {
  }

  [HttpGet]
  public ActionResult<EntryPoint> GetAll() => new EntryPoint();
}

public class EntryPoint
{
  public string Hello { get; set; }

  public EntryPoint()
  {
    Hello = "Hello, WebAPI!";
  }
}
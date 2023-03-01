using Restful.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Restful.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
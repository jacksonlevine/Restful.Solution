using Restful.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Restful.Controllers
{
  public class EntryController : Controller
  {
    [HttpGet("/entry")]
    public ActionResult Index()
    {
      Dictionary<string, Category> allCategories = Category.GetAll();
      return View(allCategories);
    }

    [HttpPost("/entry")]
    public ActionResult NewEntry(string name, string message)
    {
      Entry newEntry = new Entry();
      newEntry.Name = name;
      newEntry.Message = message;
      Category c = new Category(DateTime.Now.ToShortDateString());
      c.Add(newEntry);
      return RedirectToAction("Index");
    }
  }
}
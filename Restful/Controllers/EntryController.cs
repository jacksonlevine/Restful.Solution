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
      List<Entry> allEntries = Entry.GetAll();
      return View(allEntries);
    }

    [HttpPost("/entry")]
    public ActionResult NewEntry(string name, string message)
    {
      Entry newEntry = new Entry();
      newEntry.Name = name;
      newEntry.Message = message;
      return RedirectToAction("Index");
    }
  }
}
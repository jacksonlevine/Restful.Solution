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
      return Entry(allItems);
    }

    [HttpGet("/entry/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/entry")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }
  }
}
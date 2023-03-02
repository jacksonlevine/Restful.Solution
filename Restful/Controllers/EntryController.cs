using Restful.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

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
      Category c = new Category(DateTime.Now.ToLongDateString()+" Hour #" +DateTime.Now.Hour.ToString());
      c.Add(newEntry);
      return RedirectToAction("Index");
    }
    [HttpGet("/entry/{idQuery}")]
    public ActionResult Show(int idQuery)
    {
      Entry foundEntry = Entry.Find(idQuery);
      return View(foundEntry);
    }
  }
}
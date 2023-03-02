using System;
using System.Collections.Generic;
namespace Restful.Models
{
  public class Entry
  {
    public string Message { get; set; }
    public string Name { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public bool Urgent { get; set; }
    public int Id { get; set; }
    private static List<Entry> _entries = new List<Entry>();
    private static int _currentId = 0;
    public Entry()
    {
      Date = DateTime.Now.ToLongDateString();
      Time = DateTime.Now.ToLongTimeString();
      Urgent = false;
      Id = _currentId;
      _currentId++;
      _entries.Add(this);
    }
    public static List<Entry> GetAll()
    {
      return _entries;
    }
    public static void ClearAll()
    {
      _entries.Clear();
      _currentId = 0;
    }
    public static Entry Find(int id)
    {
      if(_entries.Exists(ent => ent.Id == id))
      {
        return _entries.Find(ent => ent.Id == id);
      }
      Entry error = new Entry();
      error.Message = "We're sorry, an entry with this Id could not be found.";
      return error;
    }
  }
}
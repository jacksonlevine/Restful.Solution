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
    private static List<Entry> _entries = new List<Entry>();
    public Entry()
    {
      Date = DateTime.Now.ToLongDateString();
      Time = DateTime.Now.ToLongTimeString();
      Urgent = false;
      _entries.Add(this);
    }
    public static List<Entry> GetAll()
    {
      return _entries;
    }
    public static void ClearAll()
    {
      _entries.Clear();
    }
  }
}
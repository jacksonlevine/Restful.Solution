using System;
namespace Restful.Models
{
  public class Entry
  {
    public string Message { get; set; }
    public string Name { get; set; }
    public string Date { get; set; }
    public Entry()
    {
      Date = DateTime.Now.ToLongDateString();
    }
  }
}
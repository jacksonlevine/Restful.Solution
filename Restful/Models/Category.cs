using System.Collections.Generic;

namespace Restful.Models
{
  public class Category
  {
    public string Name { get; set; }
    public List<Entry> EntryList = new();
  }
}
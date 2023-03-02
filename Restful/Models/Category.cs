using System.Collections.Generic;

namespace Restful.Models
{
  public class Category
  {
    private static List<Category> _instances = new();
    public string Name { get; set; }
    public List<Entry> EntryList = new();
    public Category()
    {
      _instances.Add(this);
    }
    public static List<Category> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
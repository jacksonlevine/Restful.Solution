using System.Collections.Generic;

namespace Restful.Models
{
  public class Category
  {
    private static Dictionary<string, Category> _instances = new();
    public string Name { get; set; }
    public List<Entry> EntryList = new();
    public Category(string name)
    {
      Name = name;
      if(!_instances.ContainsKey(name))
      {
        _instances.Add(name, this);
      }
    }
    public static Dictionary<string, Category> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public void Add(Entry e)
    {
      if(_instances.ContainsKey(Name))
      {
        _instances[Name].EntryList.Add(e);
      }
    }
  }
}
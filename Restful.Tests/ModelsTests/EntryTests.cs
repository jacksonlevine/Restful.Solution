using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restful.Models;

namespace Restful.Tests
{
  [TestClass]
  public class EntryTests
  {
    [TestMethod]
    public void Entry_CreatesInstanceOfEntry_Entry()
    {
      Entry e = new Entry();
    }
  }
}
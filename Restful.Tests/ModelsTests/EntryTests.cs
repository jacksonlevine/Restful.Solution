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
      Assert.AreEqual(typeof(Entry), e.GetType());
    }
    [TestMethod]
    public void Entry_HasPublicMessageProperty_String()
    {
      Entry e = new Entry();
      e.Message = "Tester";
      Assert.AreEqual("Tester", e.Message);
    }
  }
}
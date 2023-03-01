using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restful.Models;
using System;

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
    [TestMethod]
    public void Entry_HasPublicNameProperty_String()
    {
      Entry e = new Entry();
      e.Name = "Jackson";
      Assert.AreEqual("Jackson", e.Name);
    }
    [TestMethod]
    public void Entry_HasDateStringOfWhenItWasCreated_String()
    {
      Entry e = new Entry();
      Assert.AreEqual(DateTime.Now.ToLongDateString(), e.Date);
    }
    [TestMethod]
    public void Entry_HasTimeStringOfWhatTimeItWasCreated()
    {
      Entry e = new Entry();
      Assert.AreEqual(DateTime.Now.ToLongTimeString(), e.Time);
    }
  }
}
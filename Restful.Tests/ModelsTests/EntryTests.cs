using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restful.Models;
using System;

namespace Restful.Tests
{
  [TestClass]
  public class EntryTests : IDisposable
  {
    public void Dispose()
    {
      Entry.ClearAll();
    }
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
    public void Entry_HasTimeStringOfWhatTimeItWasCreated_String()
    {
      Entry e = new Entry();
      Assert.AreEqual(DateTime.Now.ToLongTimeString(), e.Time);
    }
    [TestMethod]
    public void Entry_HasUrgentFlagFalseByDefault_Bool()
    {
      Entry e = new Entry();
      Assert.AreEqual(false, e.Urgent);
    }
    [TestMethod]
    public void Entry_HasAPrivateStaticListOfAllEntriesAccessibleThroughGetAll_ListOfString()
    {
      Entry e = new Entry();
      Entry e1 = new Entry();
      Entry e2 = new Entry();
      Assert.AreEqual(3, Entry.GetAll().Count);
    }
    [TestMethod]
    public void Entry_StaticClearAllMethodClearsEntriesList()
    {
      Entry e = new Entry();
      Entry e1 = new Entry();
      Entry e2 = new Entry();
      Entry.ClearAll();
      Assert.AreEqual(0, Entry.GetAll().Count);
    }
    [TestMethod]
    public void Entry_HasUniqueIdProperty_Int()
    {
      Entry e = new Entry();
      Assert.AreEqual(0, e.Id);
    }
    [TestMethod]
    public void Find_StaticMethodReturnsTheInstanceWithId()
    {
      Entry e = new Entry();
      e.Message = ".";
      Entry foundEntry = Entry.Find(0);
      Assert.AreEqual(".", foundEntry.Message);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restful.Models;
using System;

namespace Restful.Tests
{
  [TestClass]
  public class CategoryTests
  {
    [TestMethod]
    public void Category_CreatesInstanceOfCategory_Category()
    {
      Category c = new Category();
      Assert.AreEqual(typeof(Category), c.GetType());
    }
    [TestMethod]
    public void Category_HasPublicNameProperty_String()
    {
      Category c = new Category();
      c.Name = "Test";
      Assert.AreEqual("Test", c.Name);
    }
    [TestMethod]
    public void Category_HasPublicEntryList_ListEntry()
    {
      Category c = new Category();
      c.EntryList.Add(new Entry());
      Assert.AreEqual(1, c.EntryList.Count);
    }
  }
}
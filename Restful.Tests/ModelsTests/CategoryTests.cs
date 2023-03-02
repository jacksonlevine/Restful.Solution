using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restful.Models;
using System;

namespace Restful.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }
    [TestMethod]
    public void Category_CreatesInstanceOfCategory_Category()
    {
      Category c = new Category("Test1");
      Assert.AreEqual(typeof(Category), c.GetType());
    }
    [TestMethod]
    public void Category_HasPublicNameProperty_String()
    {
      Category c = new Category("Test1");
      Assert.AreEqual("Test1", c.Name);
    }
    [TestMethod]
    public void Category_HasPublicEntryList_ListEntry()
    {
      Category c = new Category("Test2");
      c.EntryList.Add(new Entry());
      Assert.AreEqual(1, c.EntryList.Count);
    }

    [TestMethod]
    public void GetAll_StaticMethodReturnsAllInstancesOfCategory_ListCategory()
    {
      Category c = new Category("Test");
      Assert.AreEqual(Category.GetAll().Count, 1);
    }

    [TestMethod]
    public void Add_AddsToEntryListOrToDictionariedCategorysEntryListIfItsThere_Void()
    {
      Category c = new Category("Test");
      Entry e = new();
      c.Add(e);
      Category c2 = new Category("Test");
      Entry e2 = new();
      c2.Add(e2);
      Assert.AreEqual(2, c.EntryList.Count);
    }
  }
}
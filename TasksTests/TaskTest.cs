namespace LagavulinSoftware.Tests
{
  using System;
  using LagavulinSoftware.Core;
  using NUnit.Framework;

  [TestFixture]
  public class TaskTest
  {
    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void Test_Task_Constructed_With_Empty_Name_Throws()
    {
      string description = string.Empty;
      this.CreateTask(description);
    }

    [Test]
    public void Test_New_Task_Has_Given_Description()
    {
      string descr = "Learn C#!";
      Task t = this.CreateTask(descr);
      Assert.AreEqual(descr, t.Description);
    }

    private Task CreateTask(string desc)
    {
      return new Task(desc);
    }
  }
}
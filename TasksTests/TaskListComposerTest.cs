namespace LagavulinSoftware.Tests
{
  using System;
  using System.Collections.Generic;
  using NUnit.Framework;
  using LagavulinSoftware.Core;
  using LagavulinSoftware.GUI;
  using Moq;

  [TestFixture]
  public class TaskComposerTest
  {
    [Test]
    public void Test_Constructor_Does_Not_Throw()
    {
      var mockView = new Mock<ITaskListComposerView>();
      new TaskListComposer(mockView.Object);
    }

    [Test]
    public void Test_Constructor_Does_Not_Set_Task_List_On_View()
    {
      var mockView = new Mock<ITaskListComposerView>();
      var composer = new TaskListComposer(mockView.Object);
      mockView.Verify(m => m.SetTaskList(It.IsAny<List<Task>>()), Times.Never());
    }

    [Test]
    public void Test_Task_List_Is_Created_Empty()
    {
      var mockView = new Mock<ITaskListComposerView>();
      var composer = new TaskListComposer(mockView.Object);
      Assert.AreEqual(0, composer.NumberOfTasks);
    }

    [Test]
    public void Test_Initialize_Sets_Task_List_On_View()
    {
      var mockView = new Mock<ITaskListComposerView>();
      var composer = new TaskListComposer(mockView.Object);
      composer.Initialize();
      mockView.Verify(m => m.SetTaskList(It.IsAny<List<Task>>()), Times.Once());
    }
  }
}


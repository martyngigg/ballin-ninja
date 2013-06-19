namespace LagavulinSoftware.GUI
{
  using System.Collections.Generic;
  using LagavulinSoftware.Core;

  public interface ITaskListComposerView
  {
    void SetTaskList(List<Task> tasks);
  }
}

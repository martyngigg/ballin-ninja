namespace LagavulinSoftware.GUI
{
  using System;
  using System.Collections.Generic;
  using LagavulinSoftware.Core;

  /// <summary>
  /// Presenter for a list of tasks
  /// </summary>
  public class TaskListComposer
  {
    /// <summary>
    /// Reference to the view
    /// </summary>
    private ITaskListComposerView view;

    /// <summary>
    ///  Holds the list of tasks
    /// </summary>
    private List<Task> tasks;

    /// <summary>
    /// Construct a TaskListComposer with a view
    /// </summary>
    /// <param name="view">A view object that will display the tasks</param>
    public TaskListComposer(ITaskListComposerView view)
    {
      this.tasks = new List<Task>();
      this.view = view;
    }

    /// <summary>
    /// Gets the number of tasks in the current list
    /// </summary>
    public int NumberOfTasks
    {
      get
      {
        return this.tasks.Count;
      }
    }

    /// <summary>
    /// Initializes the view with the current task list
    /// </summary>
    public void Initialize()
    {
      this.view.SetTaskList(this.tasks);
    }
  }
}

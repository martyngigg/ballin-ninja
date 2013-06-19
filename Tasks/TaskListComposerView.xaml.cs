using System.Collections.Generic;
using System.Windows.Controls;

using LagavulinSoftware.GUI;

namespace Tasks
{
  /// <summary>
  /// Interaction logic for TaskListComposerView.xaml
  /// </summary>
  public partial class TaskListComposerView : UserControl, ITaskListComposerView
  {
    public TaskListComposerView()
    {
      InitializeComponent();
    }

    public void SetTaskList(List<LagavulinSoftware.Core.Task> tasks)
    {
      UpdateDisplay(tasks);
    }

    private void UpdateDisplay(List<LagavulinSoftware.Core.Task> tasks)
    {
      var displayedItems = this.DescriptionList.Items;
      displayedItems.Clear();
      foreach (var task in tasks)
      {
        displayedItems.Add(task.Description);
      }
    }
  }
}

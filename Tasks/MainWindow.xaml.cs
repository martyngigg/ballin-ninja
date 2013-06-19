namespace Tasks
{
  using System.Windows;

  using LagavulinSoftware.Core;
  using LagavulinSoftware.GUI;

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private TaskListComposer Composer;

    public MainWindow()
    {
      InitializeComponent();

      Composer = new TaskListComposer(this.TaskListView);
      Composer.Initialize();
    }
  }
}

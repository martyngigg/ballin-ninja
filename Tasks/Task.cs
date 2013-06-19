using System;

namespace LagavulinSoftware.Core
{
    /// <summary>
    /// Defines a single task with a description
    /// </summary>
    public class Task
    {
      /// <summary>
      /// Constructs a new task with a given description string
      /// </summary>
      /// <param name="descr">A string describing the task</param>
      public Task(string descr)
      {
        if (descr.Length == 0)
        {
          throw new ArgumentException("Task description cannot be empty");
        }

        this.Description = descr;
      }

      /// <summary>
      /// Gets the description of task
      /// </summary>
      public string Description { get; private set;  }
    }
}

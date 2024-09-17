using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  enum ActionState
  {
    None,
    Pending,
    Running,
    Finished
  }

  internal class PendingAction
  {
    public string? Name { get; set; }
    public ActionState State { get; set; }
    public bool Enabled { get; set; }
    public Dictionary<string, object>? Arguments { get; set; }
    public string? Queue { get; set; }
    public DateTime QueuedAt { get; set; }
    public DateTime StartedAd { get; set; }

    public static ObservableCollection<PendingAction> GetAll()
    {
      ObservableCollection<PendingAction> actions = new ObservableCollection<PendingAction>();
      Random random = new Random();

      for (int i = 1; i <= 10; i++)
      {
        PendingAction action = new PendingAction
        {
          Name = $"Action{i}",
          State = (ActionState)random.Next(0, 4), // Random state (Pending, InProgress, Completed, Failed)
          Enabled = random.Next(0, 2) == 1,
          Arguments = new Dictionary<string, object>
                {
                    { "Arg1", random.Next(100) }, // Sample argument
                    { "Arg2", $"Value{i}" }
                },
          Queue = $"Queue{i}",
          QueuedAt = DateTime.Now.AddMinutes(-random.Next(1, 1000)), // Random time when it was queued
          StartedAd = DateTime.Now.AddMinutes(-random.Next(1, 500))  // Random time when it started
        };

        actions.Add(action);
      }

      return actions;
    }
  }
}

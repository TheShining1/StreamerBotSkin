using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace StreamerBotSkin.Models
{
  internal class SBQueue
  {
    public string? Name { get; set; }
    public int PendingCount { get; set; }
    public int CompletedCount { get; set; }
    public bool Paused { get; set; }
    public bool Blocking { get; set; }

    public static ObservableCollection<SBQueue> GetAll()
    {
      ObservableCollection<SBQueue> queues = new ObservableCollection<SBQueue>();
      Random random = new Random();

      for (int i = 1; i <= 10; i++)
      {
        SBQueue queue = new SBQueue
        {
          Name = $"Queue{i}",
          PendingCount = random.Next(0, 100), // Random pending count
          CompletedCount = random.Next(0, 100), // Random completed count
          Paused = random.Next(0, 2) == 1, // Random true/false
          Blocking = random.Next(0, 2) == 1 // Random true/false
        };

        queues.Add(queue);
      }

      return queues;
    }
  }
}

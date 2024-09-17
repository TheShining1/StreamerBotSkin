using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Collections;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  internal class QueuesViewModel
  {
    public DataGridCollectionView Queues { get; set; } = new DataGridCollectionView(SBQueue.GetAll());
  }
}

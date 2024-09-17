using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Collections;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  internal class QueuesViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;
    public DataGridCollectionView Queues { get; set; } = new DataGridCollectionView(SBQueue.GetAll());
  }
}

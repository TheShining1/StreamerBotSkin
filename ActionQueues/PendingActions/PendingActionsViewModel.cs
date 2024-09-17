using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Avalonia.Collections;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  public class PendingActionsViewModel : ViewModelBase
  {
    public string Name { get; set; } = "PendingActionsViewModel";

    public DataGridCollectionView PendingActions { get; set; } = new DataGridCollectionView(PendingAction.GetAll());
  }
}

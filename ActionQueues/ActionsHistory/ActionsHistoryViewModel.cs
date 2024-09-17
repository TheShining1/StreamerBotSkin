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
  public class ActionsHistoryViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;

    public DataGridCollectionView ActionsHistory { get; set; } = new DataGridCollectionView(PendingAction.GetAll());
  }
}

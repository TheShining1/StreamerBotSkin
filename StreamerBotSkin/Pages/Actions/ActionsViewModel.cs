using System;
using System.Windows.Input;
using ReactiveUI;
using System.Collections.ObjectModel;
using StreamerBotSkin.Models;
using Avalonia.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;

namespace StreamerBotSkin.ViewModels
{
  public class ActionsViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;
    private DataGridCollectionView actionsItems = LoadActions();
    public DataGridCollectionView ActionsItems
    {
      get => actionsItems;
      set => this.RaiseAndSetIfChanged(ref actionsItems, value);
    }

    public static DataGridCollectionView LoadActions()
    {
      var actions = SBAction.GetAll();
      var actionsCollectionView = new DataGridCollectionView(actions);
      actionsCollectionView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));

      return actionsCollectionView;
    }

    public ObservableCollection<SBQueue> queuesItems = LoadQueues();
    public ObservableCollection<SBQueue> QueuesItems
    {
      get => queuesItems;
      set => this.RaiseAndSetIfChanged(ref queuesItems, value);
    }

    public static ObservableCollection<SBQueue> LoadQueues()
    {
      return SBQueue.GetAll();
    }

    private SBAction? _currentAction;
    public SBAction? currentAction
    {
      get { return _currentAction; }
      set
      {
        this.RaiseAndSetIfChanged(ref _currentAction, value);
      }
    }

    private ObservableCollection<SBSubAction>? _currentSubActions;
    public ObservableCollection<SBSubAction>? currentSubActions
    {
      get { return _currentSubActions; }
      set { _currentSubActions = value; }
    }

    private SBQueue? selectedQueue;
    public SBQueue? SelectedQueue
    {
      get => selectedQueue;
      set
      {
        this.RaiseAndSetIfChanged(ref selectedQueue, value);
        SelectedQueueId = value?.ID;
      }
    }

    private string? selectedQueueId;
    public string? SelectedQueueId
    {
      get => selectedQueueId;
      set => this.RaiseAndSetIfChanged(ref selectedQueueId, value);
    }
  }
}
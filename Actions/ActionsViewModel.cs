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

namespace StreamerBotSkin.ViewModels
{
  public class ActionsViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;
    public DataGridCollectionView actionsItems { get; set; } = LoadActions();

    public static DataGridCollectionView LoadActions()
    {
      var actions = SBAction.GetAll();
      var actionsCollectionView = new DataGridCollectionView(actions);
      actionsCollectionView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));

      return actionsCollectionView;
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
  }
}
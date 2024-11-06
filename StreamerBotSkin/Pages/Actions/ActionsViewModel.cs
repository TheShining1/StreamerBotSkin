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
using Avalonia.Controls;

namespace StreamerBotSkin.ViewModels
{
  public class ActionsViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;

    private DataGridCollectionView actionsItemsFiltered = setActions();
    public DataGridCollectionView ActionsItemsFiltered
    {
      get => actionsItemsFiltered;
      set => this.RaiseAndSetIfChanged(ref actionsItemsFiltered, value);
    }

    private string? nameFilter;
    public string? NameFilter
    {
      get => nameFilter;
      set
      {
        this.RaiseAndSetIfChanged(ref nameFilter, value);
        nameFilterFunc(value);
      }
    }

    private static DataGridCollectionView setActions()
    {
      var actionsItemsFilteredView = new DataGridCollectionView(SBAction.GetAll());
      actionsItemsFilteredView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));
      return actionsItemsFilteredView;
    }

    void nameFilterFunc(string? name)
    {
      var actionsItemsFilteredView = new DataGridCollectionView(new ObservableCollection<SBAction>());
      if (name == null)
      {
        actionsItemsFilteredView = new DataGridCollectionView(ActionsItems);
      }
      else
      {
        actionsItemsFilteredView = new DataGridCollectionView(
          ActionsItems.Where(a => a.Name.ToLower().Contains(name.ToLower()))
        );
      }

      actionsItemsFilteredView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));
      ActionsItemsFiltered = actionsItemsFilteredView;
    }

    private ObservableCollection<SBAction> actionsItems = SBAction.GetAll();
    public ObservableCollection<SBAction> ActionsItems
    {
      get => actionsItems;
      set
      {
        this.RaiseAndSetIfChanged(ref actionsItems, value);
        //nameFilterFunc(null);
      }
    }

    public ObservableCollection<SBQueue> queuesItems = SBQueue.GetAll();
    public ObservableCollection<SBQueue> QueuesItems
    {
      get => queuesItems;
      set => this.RaiseAndSetIfChanged(ref queuesItems, value);
    }

    private SBAction? _currentAction;
    public SBAction? currentAction
    {
      get { return _currentAction; }
      set
      {
        this.RaiseAndSetIfChanged(ref _currentAction, value);
        generateSubActionTree(value);
      }
    }

    void generateSubActionTree(SBAction? value)
    {
      CurrentSubActionsTree = new List<SBNode>();
      if (value == null)
      {
        return;
      }

      if (value.ActionGroups.Count == 0)
      {
        CurrentSubActionsTree = value.Actions.Select(action => new SBNode { ID=action.ID, Name=action.Type.ToString() }).ToList();

        return;
      };

      var groupedTree = new List<SBNode>();
      foreach (var group in value.ActionGroups)
      {
        var items = value.Actions.Where(action => string.Equals(action.Group, group.Name, StringComparison.CurrentCultureIgnoreCase));
        
        groupedTree.Add(new SBNode {
          IsExpanded = true,
          ID = group.ID,
          Name = group.Name,
          Items = items.Select(action => new SBNode { ID = action.ID, Name = action.Type.ToString() }).ToList()
        });
      }

      //var treeView = new List<TreeViewItem>();

      //var treeViewItem = new TreeViewItem();
      //treeViewItem.ItemsSource = value.Actions;

      //treeView.Add(treeViewItem);

      CurrentSubActionsTree = groupedTree;


      //var treeGroupsItem = new TreeViewItem();
      //treeGroupsItem.Items = List<SBSubAction>();



      //foreach (var action in value.Actions)
      //{
      //  if (action.Group == null)
      //  {
      //    currentSubActionsTree.Add(action);
      //    continue;
      //  }


      //  currentSubActionsTree.Add
      //}
    }

    static List<SBNode> GenTestTree()
    {
      var tree = new List<SBNode>();

      for (var i = 0; i < 10; i++)
      {
        var item = new SBNode() {
          ID=$"{i}",
          Name=$"Node_{i}",
          Items=null
        };

        var items = new List<SBNode>();
        for (var j = 0; j < 10; j++)
        {
          items.Add(new SBNode() {
            ID=$"{j}",
            Name=$"Sub_Node_{j}"
          });
        }

        item.Items = items;

        tree.Add(item);
      }

      return tree;
    }

    private List<SBNode> testTree = new List<SBNode>();
    public List<SBNode> TestTree
    {
      get => testTree;
      set => this.RaiseAndSetIfChanged(ref testTree, value);
    }

    private List<SBNode> currentSubActionsTree = new List<SBNode>();
    public List<SBNode> CurrentSubActionsTree
    {
      get => currentSubActionsTree;
      set => this.RaiseAndSetIfChanged(ref currentSubActionsTree, value);
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

  public class SBNode
  {
    public string ID { get; set; }
    public string Name { get; set; }
    public List<SBNode> Items { get; set; }
    public bool IsExpanded { get; set; }
  }
}
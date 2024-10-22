using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using StreamerBotSkin.Models;
using StreamerBotSkin.ViewModels;

using System.Collections.ObjectModel;

namespace StreamerBotSkin.Panels;

public partial class ActionsPanel : UserControl
{
  public ActionsPanel()
  {
    InitializeComponent();
  }

  //public static readonly DirectProperty<ActionsPanel, DataGridCollectionView> ItemsProperty =
  //    AvaloniaProperty.RegisterDirect<ActionsPanel, DataGridCollectionView>(
  //        nameof(Items),
  //        o => o.Items,
  //        (o, v) => o.Items = v);

  //private DataGridCollectionView _items = new DataGridCollectionView(new ObservableCollection<SBAction>());
  //public DataGridCollectionView Items
  //{
  //  get { return _items; }
  //  set { SetAndRaise(ItemsProperty, ref _items, value); }
  //}

  //public static readonly DirectProperty<ActionsPanel, SBAction> CurrentItemProperty =
  //    AvaloniaProperty.RegisterDirect<ActionsPanel, SBAction>(
  //        nameof(CurrentItem),
  //        o => o.CurrentItem,
  //        (o, v) => o.CurrentItem = v);

  //private SBAction _currentItem = new SBAction();
  //public SBAction CurrentItem
  //{
  //  get { return _currentItem; }
  //  set { SetAndRaise(CurrentItemProperty, ref _currentItem, value); }
  //}

  //public static readonly DirectProperty<ActionsPanel, int> CurrentItemIndexProperty =
  //    AvaloniaProperty.RegisterDirect<ActionsPanel, int>(
  //        nameof(CurrentItemIndex),
  //        o => o.CurrentItemIndex,
  //        (o, v) => o.SelectedIndex = v);

  //private int _currentItemIndex = 0;
  //public int CurrentItemIndex
  //{
  //  get { return _currentItemIndex; }
  //  set { SetAndRaise(CurrentItemIndexProperty, ref _currentItemIndex, value); }
  //}
}
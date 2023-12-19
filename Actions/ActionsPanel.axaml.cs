using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using StreamerBotSkin.Models;
using System.Collections.ObjectModel;

namespace StreamerBotSkin.Controls;

public partial class ActionsPanel : UserControl
{
    public ActionsPanel()
    {
        InitializeComponent();
    }

    public static readonly DirectProperty<ActionsPanel, DataGridCollectionView> ItemsProperty =
        AvaloniaProperty.RegisterDirect<ActionsPanel, DataGridCollectionView>(
            nameof(Items),
            o => o.Items,
            (o, v) => o.Items = v);

    private DataGridCollectionView _items = new DataGridCollectionView(new ObservableCollection<SBAction>());
    public DataGridCollectionView Items
    {
        get { return _items; }
        set { SetAndRaise(ItemsProperty, ref _items, value); }
    }

    public static readonly DirectProperty<ActionsPanel, object> CurrentItemProperty =
        AvaloniaProperty.RegisterDirect<ActionsPanel, object>(
            nameof(CurrentItem),
            o => o.CurrentItem);

    private object _currentItem = new object();
    public object CurrentItem
    {
        get { return _currentItem; }
        //set { SetAndRaise(CurrentItemProperty, ref _currentItem, value); }
    }
}
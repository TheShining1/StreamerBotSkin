using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using StreamerBotSkin.Models;
using System.Collections.ObjectModel;

namespace StreamerBotSkin.Panels;

public partial class TriggersPanel : UserControl
{
    public TriggersPanel()
    {
        InitializeComponent();
    }

    //public static readonly DirectProperty<TriggersPanel, DataGridCollectionView> ItemsProperty =
    //    AvaloniaProperty.RegisterDirect<TriggersPanel, DataGridCollectionView>(
    //        nameof(Items),
    //        o => o.Items,
    //        (o, v) => o.Items = v);

    //private DataGridCollectionView _items = new DataGridCollectionView(new ObservableCollection<SBAction>());
    //public DataGridCollectionView Items
    //{
    //    get { return _items; }
    //    set { SetAndRaise(ItemsProperty, ref _items, value); }
    //}
}
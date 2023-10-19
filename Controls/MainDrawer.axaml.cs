using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using static StreamerBotSkin.Controls.MainDrawer;

namespace StreamerBotSkin.Controls;

public partial class MainDrawer : UserControl
{
    //public class ViewSelectedEventArgs : RoutedEventArgs
    //{
    //    private readonly int _selectedIndex;

    //    public int SelectedIndex { get; set; }

    //    public ViewSelectedEventArgs(RoutedEvent routedEvent, int selectedIndex) : base(routedEvent)
    //    {
    //        this._selectedIndex = selectedIndex;
    //    }
    //}
    public MainDrawer()
    {
        InitializeComponent();

        GlobalCommands.mainDrawer = this;

        DrawerList.PointerReleased += DrawerSelectionChanged;
        DrawerList.KeyUp += DrawerList_KeyUp;
    }

    //public static readonly RoutedEvent<ViewSelectedEventArgs> ViewSelectedEvent =
    //    RoutedEvent.Register<MainDrawer, ViewSelectedEventArgs>(nameof(ViewSelected), RoutingStrategies.Tunnel);

    //public event EventHandler<ViewSelectedEventArgs> ViewSelected
    //{
    //    add => AddHandler(ViewSelectedEvent, value);
    //    remove => RemoveHandler(ViewSelectedEvent, value);
    //}

    public static readonly DirectProperty<MainDrawer, int> SelectedViewProperty =
        AvaloniaProperty.RegisterDirect<MainDrawer, int>(
            nameof(SelectedView),
            o => o.SelectedView,
            (o, v) => o.SelectedView = v);

    private int _selectedView = 0;
    public int SelectedView
    {
        get { return _selectedView; }
        set { SetAndRaise(SelectedViewProperty, ref _selectedView, value); }
    }

    private void DrawerList_KeyUp(object? sender, RoutedEventArgs e)
    {
        var listBox = sender as ListBox;
        if (listBox == null) return;

        GlobalCommands.mainCarousel.SelectedView = listBox.SelectedIndex;

        //SelectedView = listBox.SelectedIndex;

        //DataContext.CurrentView = listBox.SelectedItem;

        //ViewSelectedEventArgs args = new ViewSelectedEventArgs(ViewSelectedEvent, listBox.SelectedIndex);
        //RaiseEvent(args);
    }

    private void DrawerSelectionChanged(object? sender, RoutedEventArgs e)
    {
        var listBox = sender as ListBox;
        if (listBox == null) return;
        if (!listBox.IsFocused && !listBox.IsKeyboardFocusWithin) return;

        GlobalCommands.mainCarousel.SelectedView = listBox.SelectedIndex;

        //SelectedView = listBox.SelectedIndex;

        //DataContext.CurrentView = listBox.SelectedItem;

        //ViewSelectedEventArgs args = new ViewSelectedEventArgs(ViewSelectedEvent, listBox.SelectedIndex);
        //RaiseEvent(args);
    }
}
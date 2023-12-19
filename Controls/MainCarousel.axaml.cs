using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls;

public partial class MainCarousel : UserControl
{
    public MainCarousel()
    {
        InitializeComponent();

        //GlobalCommands.mainCarousel = this;
    }

    public static readonly DirectProperty<MainCarousel, int> SelectedViewProperty =
        AvaloniaProperty.RegisterDirect<MainCarousel, int>(
            nameof(SelectedView),
            o => o.SelectedView,
            (o, v) => o.SelectedView = v);

    private int _selectedView = 0;
    public int SelectedView
    {
        get { return _selectedView; }
        set { SetAndRaise(SelectedViewProperty, ref _selectedView, value); }
    }
}
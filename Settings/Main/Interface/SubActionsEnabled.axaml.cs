using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Views;

namespace StreamerBotSkin.Controls;

public partial class SubActionsEnabled : UserControl
{
    public SubActionsEnabled()
    {
        InitializeComponent();
    }

    public static readonly StyledProperty<string> TitleProperty =
      AvaloniaProperty.Register<InterfaceView, string>(
        nameof(Title)
      );

    public string Title
    {
      get { return GetValue(TitleProperty); }
      set { SetValue(TitleProperty, value); }
    }
}
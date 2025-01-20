using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotControls;

public partial class StartStopToggleButton : UserControl
{
  public StartStopToggleButton()
  {
      InitializeComponent();
  }

  public static readonly StyledProperty<bool> AutoStartProperty =
    AvaloniaProperty.Register<StartStopToggleButton, bool>(
      nameof(AutoStart),
      true
      );

  public bool AutoStart
  {
    get { return GetValue(AutoStartProperty); }
    set { SetValue(AutoStartProperty, value); }
  }
}
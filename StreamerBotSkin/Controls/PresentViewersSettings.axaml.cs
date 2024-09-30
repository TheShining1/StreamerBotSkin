using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls;

public partial class PresentViewersSettings : UserControl
{
  public PresentViewersSettings()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<int> MinimumProperty =
    AvaloniaProperty.Register<PresentViewersSettings, int>(
      nameof(Minimum),
      1
      );

  public int Minimum
  {
    get { return GetValue(MinimumProperty); }
    set { SetValue(MinimumProperty, value); }
  }

  public static readonly StyledProperty<int> MaximumProperty =
    AvaloniaProperty.Register<PresentViewersSettings, int>(
      nameof(Maximum),
      10
      );

  public int Maximum
  {
    get { return GetValue(MaximumProperty); }
    set { SetValue(MaximumProperty, value); }
  }
}
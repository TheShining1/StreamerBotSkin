using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;

namespace StreamerBotControls;

public partial class ColoredTextField : UserControl
{
  public ColoredTextField()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<string?> ColorProperty =
    AvaloniaProperty.Register<ColoredTextField, string?>(
      nameof(Color),
      null,
      default,
      BindingMode.TwoWay
    );

  public string? Color
  {
    get { return GetValue(ColorProperty); }
    set { SetValue(ColorProperty, value); }
  }

  public static readonly StyledProperty<string?> NewColorProperty =
    AvaloniaProperty.Register<ColoredTextField, string?>(
      nameof(NewColor),
      null,
      default,
      BindingMode.TwoWay
    );

  public string? NewColor
  {
    get { return GetValue(NewColorProperty); }
    set { SetValue(NewColorProperty, value); }
  }

  private async void SaveColor(object sender, RoutedEventArgs args)
  {
    Color = NewColor;    
  }
}
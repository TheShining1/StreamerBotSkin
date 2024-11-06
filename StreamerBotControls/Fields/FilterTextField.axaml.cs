using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace StreamerBotControls;

public partial class FilterTextField : UserControl
{
  public FilterTextField()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<string?> TextProperty =
    AvaloniaProperty.Register<FilterTextField, string?>(
      nameof(Text),
      null,
      default,
      BindingMode.OneWayToSource
    );

  public string? Text
  {
    get { return GetValue(TextProperty); }
    set { SetValue(TextProperty, value); }
  }
}
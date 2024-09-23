using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls;

public partial class LabelledItemsControl : UserControl
{
  public LabelledItemsControl()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<string> LabelProperty =
  AvaloniaProperty.Register<LabelledTextBlock, string>(
    nameof(Label)
  );

  public string Label
  {
    get { return GetValue(LabelProperty); }
    set { SetValue(LabelProperty, value); }
  }
}
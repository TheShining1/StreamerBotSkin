using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Controls;

public partial class LabelledTextBlock : UserControl
{
  public LabelledTextBlock()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<string> GroupProperty =
  AvaloniaProperty.Register<LabelledTextBlock, string>(
    nameof(Group)
  );

  public string Group
  {
    get { return GetValue(GroupProperty); }
    set { SetValue(GroupProperty, value); }
  }

  public new static readonly StyledProperty<string> HorizontalAlignmentProperty =
  AvaloniaProperty.Register<LabelledTextBlock, string>(
    nameof(HorizontalAlignment),
    "Right"
  );

  public new string HorizontalAlignment
  {
    get { return GetValue(HorizontalAlignmentProperty); }
    set { SetValue(HorizontalAlignmentProperty, value); }
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

  public static readonly StyledProperty<string> TextProperty =
  AvaloniaProperty.Register<LabelledTextBlock, string>(
    nameof(Text)
  );

  public string Text
  {
    get { return GetValue(TextProperty); }
    set { SetValue(TextProperty, value); }
  }
}
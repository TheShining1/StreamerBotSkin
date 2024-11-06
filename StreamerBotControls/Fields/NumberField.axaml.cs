using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace StreamerBotControls;

public partial class NumberField : UserControl
{
  public NumberField()
  {
    InitializeComponent();
  }

  public static readonly DirectProperty<TextField, string?> TitleProperty =
    AvaloniaProperty.RegisterDirect<TextField, string?>(
      nameof(Title),
      o => o.Title,
      (o, v) => o.Title = v
    );

  private string? title;
  public string? Title
  {
    get { return title; }
    set { SetAndRaise(TitleProperty, ref title, value); }
  }

  public static readonly DirectProperty<NumberField, string?> TextProperty =
    AvaloniaProperty.RegisterDirect<NumberField, string?>(
      nameof(Text),
      o => o.Text,
      (o, v) => o.Text = v
    );

  private string? text;
  public string? Text
  {
    get { return text; }
    set { SetAndRaise(TextProperty, ref text, value); }
  }

  public static readonly StyledProperty<uint> MinimumProperty =
    AvaloniaProperty.Register<NumberField, uint>(
      nameof(Minimum),
      uint.MinValue,
      default
    );

  public uint Minimum
  {
    get { return GetValue(MinimumProperty); }
    set { SetValue(MinimumProperty, value); }
  }

  public static readonly StyledProperty<uint> MaximumProperty =
    AvaloniaProperty.Register<NumberField, uint>(
      nameof(Maximum),
      uint.MaxValue,
      default
    );

  public uint Maximum
  {
    get { return GetValue(MaximumProperty); }
    set { SetValue(MaximumProperty, value); }
  }

  public static readonly StyledProperty<uint> ValueProperty =
    AvaloniaProperty.Register<NumberField, uint>(
      nameof(Value),
      uint.MinValue,
      default,
      BindingMode.TwoWay
    );

  public uint Value
  {
    get { return GetValue(ValueProperty); }
    set { SetValue(ValueProperty, value); }
  }
}
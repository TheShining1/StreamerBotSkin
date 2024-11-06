using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace StreamerBotControls;

public partial class MultilineTextField : UserControl
{
  public MultilineTextField()
  {
    InitializeComponent();
  }

  public static readonly DirectProperty<MultilineTextField, string?> TitleProperty =
    AvaloniaProperty.RegisterDirect<MultilineTextField, string?>(
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

  public static readonly StyledProperty<string?> TextProperty =
    AvaloniaProperty.Register<MultilineTextField, string?>(
      nameof(TextProperty),
      null,
      default,
      BindingMode.TwoWay,
      default,
      onTextChanged
    );

  public string? Text
  {
    get { return GetValue(TextProperty); }
    set { SetValue(TextProperty, value); }
  }

  private static string? onTextChanged(AvaloniaObject sender, string? value)
  {
    var textField = sender as MultilineTextField;
    if (textField != null && value != null && textField.Length != null)
    {
      textField.Counter = $"{value.Length}/{textField.Length}";
    }

    return value;
  }

  public static readonly StyledProperty<uint?> LengthProperty =
    AvaloniaProperty.Register<MultilineTextField, uint?>(
      nameof(Length),
      null,
      default,
      default,
      default,
      onLengthChanged
    );

  public uint? Length
  {
    get { return GetValue(LengthProperty); }
    set { SetValue(LengthProperty, value); }
  }

  private static uint? onLengthChanged(AvaloniaObject sender, uint? value)
  {
    var textField = sender as MultilineTextField;
    if (textField != null && value != null)
    {
      textField.Counter = $"{textField.Text?.Length ?? 0}/{value}";
    }

    return value;
  }

  public static readonly StyledProperty<string?> CounterProperty =
    AvaloniaProperty.Register<MultilineTextField, string?>(
      nameof(Counter),
      null
    );

  public string? Counter
  {
    get { return GetValue(CounterProperty); }
    set { SetValue(CounterProperty, value); }
  }
}
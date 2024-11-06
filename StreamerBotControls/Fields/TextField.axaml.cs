using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace StreamerBotControls;

public partial class TextField : UserControl
{
  public TextField()
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

  public static readonly StyledProperty<string?> TextProperty =
    AvaloniaProperty.Register<TextField, string?>(
      nameof(Text),
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
    var textField = sender as TextField;
    if (textField != null && value != null && textField.Length != null)
    {
      textField.Counter = $"{value.Length}/{textField.Length}";    
    }

    return value;
  }

  public static readonly StyledProperty<uint?> LengthProperty =
    AvaloniaProperty.Register<TextField, uint?>(
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
    var textField = sender as TextField;
    if (textField != null && value != null)
    {
      textField.Counter = $"{textField.Text?.Length ?? 0}/{value}";
    }

    return value;
  }

  public static readonly StyledProperty<string?> CounterProperty =
    AvaloniaProperty.Register<TextField, string?>(
      nameof(Counter),
      null
    );

  public string? Counter
  {
    get { return GetValue(CounterProperty); }
    set { SetValue(CounterProperty, value); }
  }
}
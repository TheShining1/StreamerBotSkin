using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace StreamerBotControls;

public partial class SensitiveTextField : UserControl
{
  public SensitiveTextField()
  {
    InitializeComponent();
  }

  public static readonly DirectProperty<SensitiveTextField, string?> TitleProperty =
    AvaloniaProperty.RegisterDirect<SensitiveTextField, string?>(
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
    AvaloniaProperty.Register<SensitiveTextField, string?>(
      nameof(Text),
      null,
      default,
      BindingMode.TwoWay
    );

  public string? Text
  {
    get { return GetValue(TextProperty); }
    set { SetValue(TextProperty, value); }
  }
}
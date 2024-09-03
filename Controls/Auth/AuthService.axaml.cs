using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls.Auth;

public partial class AuthService : UserControl
{
    public AuthService()
    {
        InitializeComponent();
  }

  public static readonly StyledProperty<string> LabelProperty =
    AvaloniaProperty.Register<AuthService, string>(
      nameof(Label),
      "Client"
      );

  public string Label
  {
    get { return GetValue(LabelProperty); }
    set { SetValue(LabelProperty, value); }
  }
}
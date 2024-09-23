using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls.Auth;

public partial class AuthToken : UserControl
{
  public AuthToken()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<string> TokenHintProperty =
    AvaloniaProperty.Register<AuthToken, string>(
      nameof(TokenHint)
      );

  public string TokenHint
  {
    get { return GetValue(TokenHintProperty); }
    set { SetValue(TokenHintProperty, value); }
  }

  public static readonly StyledProperty<string> TokenLabelProperty =
    AvaloniaProperty.Register<AuthToken, string>(
      nameof(TokenLabel),
      "Token"
      );

  public string TokenLabel
  {
    get { return GetValue(TokenLabelProperty); }
    set { SetValue(TokenLabelProperty, value); }
  }
}
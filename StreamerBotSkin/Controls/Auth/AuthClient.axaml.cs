using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Controls.Auth;

public partial class AuthClient: UserControl
{
  public AuthClient()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<bool> ForgetProperty =
    AvaloniaProperty.Register<AuthServer, bool>(
      nameof(Forget),
      true
      );

  public bool Forget
  {
    get { return GetValue(ForgetProperty); }
    set { SetValue(ForgetProperty, value); }
  }
}
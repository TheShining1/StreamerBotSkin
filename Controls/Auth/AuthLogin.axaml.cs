using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using Newtonsoft.Json.Linq;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Controls.Auth;

public partial class AuthLogin : UserControl
{
  public AuthLogin()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<SBAccount> AccountProperty =
    AvaloniaProperty.Register<AuthLogin, SBAccount>(
      nameof(Account)
      );

  public SBAccount Account
  {
    get { return GetValue(AccountProperty); }
    set { SetValue(AccountProperty, value); }
  }
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls.Auth;

public partial class AuthNone : UserControl
{
    public AuthNone()
    {
        InitializeComponent();
  }

  public static readonly StyledProperty<bool> ForgetProperty =
  AvaloniaProperty.Register<AuthNone, bool>(
    nameof(Forget),
    true
    );

  public bool Forget
  {
    get { return GetValue(ForgetProperty); }
    set { SetValue(ForgetProperty, value); }
  }
}
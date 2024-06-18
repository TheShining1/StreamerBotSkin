using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Controls.Auth;

public partial class AuthServer : UserControl
{
  public AuthServer()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<bool> AddressProperty =
  AvaloniaProperty.Register<AuthServer, bool>(
    nameof(Address),
    true
    );

  public bool Address
  {
    get { return GetValue(AddressProperty); }
    set { SetValue(AddressProperty, value); }
  }

  public static readonly StyledProperty<bool> PortProperty =
  AvaloniaProperty.Register<AuthServer, bool>(
    nameof(Port),
    true
    );

  public bool Port
  {
    get { return GetValue(PortProperty); }
    set { SetValue(PortProperty, value); }
  }

  public static readonly StyledProperty<bool> EndpointProperty =
  AvaloniaProperty.Register<AuthServer, bool>(
    nameof(Endpoint),
    true
    );

  public bool Endpoint
  {
    get { return GetValue(EndpointProperty); }
    set { SetValue(EndpointProperty, value); }
  }
}
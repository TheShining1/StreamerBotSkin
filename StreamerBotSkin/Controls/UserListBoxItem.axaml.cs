using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Controls;

public partial class UserListBoxItem : UserControl
{
  public UserListBoxItem()
  {
    InitializeComponent();
  }

  public static readonly StyledProperty<SBUser> UserProperty =
    AvaloniaProperty.Register<UserListBoxItem, SBUser>(
      nameof(User)
    );

  public SBUser User
  {
    get { return GetValue(UserProperty); }
    set { SetValue(UserProperty, value); }
  }
}
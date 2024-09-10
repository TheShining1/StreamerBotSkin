using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Reflection;
using StreamerBotSkin.Models;
using System.Windows;
using System;

namespace StreamerBotSkin.Controls;

public partial class UserInfo : UserControl
{
  public UserInfo()
  {
    InitializeComponent();

    UserProperty.Changed.AddClassHandler<UserInfo>((c, e) => c.OnUserChanged(e));
  }

  public static readonly StyledProperty<SBUser> UserProperty =
    AvaloniaProperty.Register<UserInfo, SBUser>(
      nameof(User)
    );

  public SBUser User
  {
    get { return GetValue(UserProperty); }
    set { SetValue(UserProperty, value); }
  }

  private void OnUserChanged(AvaloniaPropertyChangedEventArgs e)
  {
    if (e.NewValue == null)
    {
      Groups = null;
      return;
    }
    
    SBUser user = (SBUser)e.NewValue;
    Groups = string.Join(", ", user.Groups);
  }

  private static readonly StyledProperty<string> GroupsProperty =
    AvaloniaProperty.Register<UserInfo, string>(
      nameof(Groups)
    );

  public string Groups
  {
    get { return GetValue(GroupsProperty); }
    set { SetValue(GroupsProperty, value); }
  }
}
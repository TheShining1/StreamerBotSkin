using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Reflection;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.Controls;

public partial class UserInfo : UserControl
{
  public UserInfo()
  {
    InitializeComponent();
  }

  private PropertyInfo[] _fields = typeof(SBUser).GetProperties();

  public static readonly DirectProperty<UserInfo, PropertyInfo[]> FieldsProperty =
    AvaloniaProperty.RegisterDirect<UserInfo, PropertyInfo[]>(
      nameof(Fields),
      o => o.Fields,
      (o,v) => o.Fields = v
    );

  public PropertyInfo[] Fields
  {
    get { return _fields; }
    private set { SetAndRaise(FieldsProperty, ref _fields, value); }
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
}
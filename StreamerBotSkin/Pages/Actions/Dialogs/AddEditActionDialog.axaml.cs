using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using StreamerBotControls;

namespace StreamerBotSkin.Dialogs;

public partial class AddEditActionDialog : Window
{
  public AddEditActionDialog()
  {
    InitializeComponent();

    Text = new List<string>
    {
      "Group 123",
      "Group 234",
      "Group 345",
      "Group 456"
    };
  }

  public static readonly StyledProperty<List<string>> TextProperty =
    AvaloniaProperty.Register<AddEditActionDialog, List<string>>(
      nameof(Text),
      new List<string>()
    );

  public List<string> Text
  {
    get { return GetValue(TextProperty); }
    set { SetValue(TextProperty, value); }
  }
}
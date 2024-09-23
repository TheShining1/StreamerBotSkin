using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Dialogs;

namespace StreamerBotSkin.Controls
{
  public partial class MainBarMenu : UserControl
  {
    public MainBarMenu()
    {
      InitializeComponent();
    }
    public void AboutDialog_Open(object sender, RoutedEventArgs args)
    {
      if (Program.MainWindow == null) return;
      var dialog = new AboutDialog();
      dialog.Width = Program.MainWindow.Width * 0.9;
      dialog.ShowDialog(Program.MainWindow);
    }
  }
}
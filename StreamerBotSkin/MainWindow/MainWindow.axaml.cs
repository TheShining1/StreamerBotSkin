using Avalonia.Controls;
using Avalonia.Interactivity;

namespace StreamerBotSkin.Views
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      Program.MainWindow = this;
    }
  }
}
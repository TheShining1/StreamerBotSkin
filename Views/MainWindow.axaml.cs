using Avalonia.Controls;
using Avalonia.Interactivity;
using static StreamerBotSkin.Controls.MainDrawer;

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
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace StreamerBotSkin.Pages
{
    public partial class ActionsView : UserControl
    {
        

        public ActionsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public List<string> Actions()
        {
            return new List<string>()
            {
                { "action0" },
                { "action1" },
                { "action2" },
                { "action3" }
            };
        }
    }
}
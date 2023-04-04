using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Xml.Linq;

namespace StreamerBotSkin.Pages
{
    public partial class ActionsView : UserControl
    {
        public class SBAction
        {
            public uint ID { get; set; }
            public string Name { get; set; }
        }

        public ActionsView()
        {
            InitializeComponent();

            SBActions = new ObservableCollection<SBAction>()
            {
                new SBAction() { ID=0, Name="action0" },
                new SBAction() { ID=1, Name="action1" },
                new SBAction() { ID=2, Name="action2" },
                new SBAction() { ID=3, Name="action3" }
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public ObservableCollection<SBAction> SBActions { get; set; }
    }

}
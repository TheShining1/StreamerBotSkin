using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using StreamerBotSkin.Classes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Xml.Linq;
using StreamerBotSkin.Classes;

namespace StreamerBotSkin.Pages
{
    public partial class ActionsView : UserControl
    {
        public ActionsView()
        {
            InitializeComponent();

            ActionsGrid = this.Get<DataGrid>(nameof(ActionsGrid));
            SubActionsTree = this.Get<TreeView>(nameof(SubActionsTree));

            if (ActionsGrid != null) ActionsGrid.Items = SBAction.GetAll();
            if (SubActionsTree != null) SubActionsTree.Items = SBSubAction.GetAll();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

}
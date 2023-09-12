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
using Avalonia.Collections;
using System;
using Avalonia.Controls.Templates;
using StreamerBotSkin.Controls;

namespace StreamerBotSkin.Pages
{
    public partial class ActionsView : UserControl
    {
        public ActionsView()
        {
            InitializeComponent();

            ActionsGrid = this.Get<DataGrid>(nameof(ActionsGrid));
            SubActionsTree = this.Get<TreeView>(nameof(SubActionsTree));
            TriggersGrid = this.Get<DataGrid>(nameof(TriggersGrid));

            ActionsGrid.LoadingRowGroup += OnLoadingRowGroup;

            var actionsCollectionView = new DataGridCollectionView(SBAction.GetAll());
            actionsCollectionView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));

            if (ActionsGrid != null) ActionsGrid.Items = actionsCollectionView;
            if (SubActionsTree != null) SubActionsTree.Items = SBSubAction.GetAll();
            if (TriggersGrid != null) TriggersGrid.Items = SBTrigger.GetAll();
        }

        private void OnLoadingRowGroup(object sender, DataGridRowGroupHeaderEventArgs e)
        {
            e.RowGroupHeader.Template = new FuncControlTemplate((x,y) => new GroupHeaderControl());
        }
        

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

}
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

namespace StreamerBotSkin.Pages
{
    public partial class ActionsView : UserControl
    {
        public ActionsView()
        {
            InitializeComponent();

            ActionsGrid = this.Get<DataGrid>(nameof(ActionsGrid));
            SubActionsTree = this.Get<TreeView>(nameof(SubActionsTree));

            ActionsGrid.LoadingRowGroup += OnLoadingRowGroup;

            var actionsCollectionView = new DataGridCollectionView(SBAction.GetAll());
            actionsCollectionView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));

            if (ActionsGrid != null) ActionsGrid.Items = actionsCollectionView;
            if (SubActionsTree != null) SubActionsTree.Items = SBSubAction.GetAll();
        }

        private void OnLoadingRowGroup(object sender, DataGridRowGroupHeaderEventArgs e)
        {
            e.RowGroupHeader.Template = new FuncControlTemplate((x,y) => new TextBlock{Text = "Test"});
        }
        

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

}
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using StreamerBotSkin.Controls;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.Views;

public partial class ActionsView : UserControl
{
    public ActionsView()
    {
        InitializeComponent();

        ActionsGrid = this.Get<ActionsPanel>(nameof(ActionsGrid));
        TriggersGrid = this.Get<TriggersPanel>(nameof(TriggersGrid));

        var actions = SBAction.GetAll();

        var actionsCollectionView = new DataGridCollectionView(actions);
        actionsCollectionView.GroupDescriptions.Add(new DataGridPathGroupDescription("Group"));

        if (ActionsGrid != null) ActionsGrid.Items = actionsCollectionView;
    }
}
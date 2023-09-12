using Avalonia.Controls;
using Avalonia.Media;
using static System.Net.Mime.MediaTypeNames;

namespace StreamerBotSkin.Pages
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            debugLevels.Items = new string[]
            {
                "Information",
                "Debug",
                "Verbose"
            };
            debugLevels.SelectedIndex = 1;

            CommentColor.Text = "#229977";
            CommentColor.Background = (Brush)new BrushConverter().ConvertFrom(CommentColor.Text);
            DisabledColor.Text = "#DB7093";
            DisabledColor.Background = (Brush)new BrushConverter().ConvertFrom(DisabledColor.Text);

            audioDevices.Items = new string[]
            {
                "Default",
                "Line 1",
                "Line 2"
            };
            audioDevices.SelectedIndex = 0;

            TextBlock refHelpText = new TextBlock();
            refHelpText.Text = "Any references added to this list will be automatically added to every Execute C# code when its compiled. Making changes to this list will not invalidate any currently compiled Execute C# code sud-actions";

            ToolTip refHelpTooltip = new ToolTip();
            refHelpTooltip.Content = refHelpText;

            Button refHelpBtn = new Button();
            refHelpBtn.Content = "?";
            refHelpBtn.SetValue(ToolTip.TipProperty, refHelpTooltip);
            refHelpBtn.Classes.Add("Icon");

            StackPanel refHelpPanel = new StackPanel();
            refHelpPanel.Children.Add(refHelpBtn);

            refBox.InnerRightContent = refHelpPanel;
        }
    }
}

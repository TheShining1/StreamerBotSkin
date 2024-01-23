using System.Collections.ObjectModel;
using Avalonia.Controls;
using DynamicData.Binding;
public class TabItemViewModel
{
  public string Header { get; set; }
  public string Content { get; set; }
}

namespace StreamerBotSkin.ViewModels
{
  public class IntegrationsSettingsViewModel : ViewModelBase
    {
      public ObservableCollection<TabItemViewModel> TabItems { get; } = populate();

      static ObservableCollection<TabItemViewModel> populate()
      {
        var TabItems = new ObservableCollection<TabItemViewModel>();
        for (int i = 1; i <= 20; i++)
        {
            TabItems.Add(new TabItemViewModel
            {
                Header = $"Tab {i}",
                Content = $"Content for Tab {i}"
            }
            );
        }
        return TabItems;
      }
    }
}